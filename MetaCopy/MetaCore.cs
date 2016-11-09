using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Linq;
using GlacialComponents.Controls;
using XDMessaging;
using XDMessaging.Messages;

namespace MetaCopy {

    public partial class MetaCore : Form {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        private const string pastehinttext = "paste path here to add";

        public static string envName = "MetaCopyPath";
        public static string channelName = "MetaChannel";

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private FileSystemWatcher watcher;
        private string watchPath;
        private bool isRunning;

        private string userPath;
        private bool deselectMode = true;

        private MiniMode mm;
        private PrefWindow pref;
        private MetaCopyExt ext;

        private XDMessagingClient client;
        private IXDListener listener;

        public MetaCore() {

            InitializeComponent();

            glacialList.BringToFront();
            glacialListPath.BringToFront();
            LabelHint.BringToFront();

            watcher = new FileSystemWatcher();
            watchPath = "";

            userPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MetaCopy");

            readObject(true);
            readObject(false);

            mm = new MiniMode();
            mm.setMain(this);

            pref = new PrefWindow();

            new Thread(new ThreadStart(writePath)).Start();
            startListener();

            extractSharpShell();

            //Notify MetaCopy is running.
            client = new XDMessagingClient();
            IXDBroadcaster broadcaster = client.Broadcasters.GetWindowsMessagingBroadcaster();
            broadcaster.SendToChannel("MetaStartChannel", "ProcessStarted");

            startListener();

            checkIntegrity();

            //foreach (string s in Environment.GetCommandLineArgs()){ Console.WriteLine(s); }
        }

        private void extractSharpShell() {
            try {
                string resPath = Path.Combine(Environment.CurrentDirectory, "SharpShell.dll");
                if (!File.Exists(resPath))
                    File.WriteAllBytes(resPath, MetaCopy.Properties.Resources.SharpShell);
            }
            catch (UnauthorizedAccessException ex) {
                //meh
            }
        }

        private void checkIntegrity() {
            int expInt = ProcessIntegrityChecker.GetExplorerIntegrityLevel();
            int mainInt = ProcessIntegrityChecker.GetProcessIntegrityLevel();

            if (mainInt > expInt) {
                //Show Warning
                MessageBox.Show("This app integrity level is higher than your system (you probably run this app as admin.) " +
                                "Drag and Drop will not work, thanks to Microsoft." +
                                " Please restart the app in normal mode (not run as administrator.)");
            }

//            switch (mainInt) {
//                case NativeMethods.SECURITY_MANDATORY_UNTRUSTED_RID:
//                    //this.lbIntegrityLevel.Text = "Untrusted"; break;
//                    Console.WriteLine("Untrusted");
//                    break;
//                case NativeMethods.SECURITY_MANDATORY_LOW_RID:
//                    //this.lbIntegrityLevel.Text = "Low"; break;
//                    Console.WriteLine("Low");
//                    break;
//                case NativeMethods.SECURITY_MANDATORY_MEDIUM_RID:
//                    //this.lbIntegrityLevel.Text = "Medium"; break;
//                    Console.WriteLine("Medium");
//                    break;
//                case NativeMethods.SECURITY_MANDATORY_HIGH_RID:
//                    //this.lbIntegrityLevel.Text = "High"; break;
//                    Console.WriteLine("High");
//                    break;
//                case NativeMethods.SECURITY_MANDATORY_SYSTEM_RID:
//                    //this.lbIntegrityLevel.Text = "System"; break;
//                    Console.WriteLine("System");
//                    break;
//                default:
//                    Console.WriteLine("Unknown");
//                    break;
//                    //this.lbIntegrityLevel.Text = "Unknown"; break;
//            }
        }

        private void writePath() {
            Environment.SetEnvironmentVariable(envName, Application.ExecutablePath, EnvironmentVariableTarget.User);
        }

        private void startWatch(string path) {
            watcher.Path = path;
            watcher.NotifyFilter = NotifyFilters.Size | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.*";
            watcher.Changed += OnDirectoryChanged;
            watcher.Deleted += OnDirectoryChanged;
            watcher.Created += OnDirectoryChanged;
            watcher.Renamed += OnDirectoryChanged;
            watcher.EnableRaisingEvents = true;
        }

        private void removeWatch() {
            watcher.Changed -= OnDirectoryChanged;
            watcher.Deleted -= OnDirectoryChanged;
            watcher.Created -= OnDirectoryChanged;
            watcher.Renamed -= OnDirectoryChanged;

            pathLabel.Text = "add a watch folder";
            watchPath = "";
            autoCheck.Checked = false;
        }

        private void checkExistence() {
            for (int i = 0; i < glacialList.Items.Count; i++) {
                GLItem item = glacialList.Items[i];
                string path = item.SubItems[1].Text;

                if (!File.Exists(item.SubItems[1].Text)) {

                    try {
                        if (File.GetAttributes(path).HasFlag(FileAttributes.Directory)) {
                            continue; //Exist
                        }
                    }
                    catch (FileNotFoundException ex) {
                        Console.WriteLine(ex.Message); //Don't exist
                    }

                    glacialList.Items.Remove(item);
                    i = -1;
                }
            }

            glacialList.Refresh();
        }

        private void OnDirectoryChanged(object sender, FileSystemEventArgs e) {
            if (isRunning) return;
            addFilesToList(Directory.GetDirectories(watchPath));
            addFilesToList(Directory.GetFiles(watchPath));
            checkExistence();

            setStatus("Directory structure changed. File list updated.", 1);
        }

        void panel1_DragEnter(object sender, DragEventArgs e) {
            if (isRunning) return;
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        public void panel1_DragDrop(object sender, DragEventArgs e) {
            if (isRunning) return;

            Control gl = (Control)sender;
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (gl.Name == "glacialList" || gl.Name == "dropPanel") {
                    addFilesToList(files);
                    glacialList.Refresh();
                }
                else {
                    foreach (string path in files) {
                        if (File.GetAttributes(path).HasFlag(FileAttributes.Directory)) {
                            addDestPath(path);
                        }
                    }
                    glacialListPath.Refresh();
                }
            }

            LabelHint.Visible = (glacialList.Items.Count == 0);
        }

        private bool hasThisFile(string path) {
            if (glacialList.Items.Count == 0) return false;

            foreach (GLItem item in glacialList.Items) {
                if (item.SubItems[1].Text == path) {
                    item.SubItems[0].Checked = true;
                    return true;
                }
            }

            return false;
        }

        private bool hasThisPath(string path) {
            if (glacialListPath.Items.Count == 0) return false;

            foreach (GLItem item in glacialListPath.Items) {
                if (item.SubItems[0].Text == path)
                    return true;
            }

            return false;
        }

        private void setSelectedColor(GLSubItem sub) {
            sub.ForeColor = Color.FromArgb(255, 36, 42, 52);
            sub.BackColor = Color.FromArgb(255, 242, 208, 59);
        }

        private void setDefaultColor(GLSubItem sub) {
            sub.ForeColor = Color.FromArgb(255, 141, 151, 166);
            sub.BackColor = Color.FromArgb(255, 29, 34, 41);
        }

        private void panel_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void setStatus(string msg, int type) {
            switch (type) {
                case 0: // normal
                    labelStat.Text = msg;
                    labelStat.ForeColor = Color.FromArgb(255, 141, 151, 166);
                    break;
                case 1: // success
                    labelStat.Text = msg;
                    labelStat.ForeColor = Color.FromArgb(255, 27, 221, 151);
                    break;
                case 2: // warning
                    labelStat.Text = msg;
                    labelStat.ForeColor = Color.FromArgb(255, 246, 84, 110);
                    break;
            }
        }

        protected override void WndProc(ref Message m) {
            if (m.Msg == NativeMethods.WM_SHOWME) {
                if (WindowState == FormWindowState.Minimized) {
                    WindowState = FormWindowState.Normal;
                }

                bool top = TopMost;
                TopMost = true;
                TopMost = top;
            }

            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void glacialList_ItemChangedEvent(object source, ChangedEventArgs e) {
            if (e.ChangedType == ChangedTypes.SelectionChanged || e.ChangedType == ChangedTypes.SubItemChanged) {
                if (e.Item.SubItems[0].Checked) {
                    setSelectedColor(e.Item.SubItems[0]);
                    setSelectedColor(e.Item.SubItems[1]);
                    setSelectedColor(e.Item.SubItems[2]);

                    glacialList.SelectedTextColor = Color.FromArgb(255, 36, 42, 52);
                    glacialList.SelectionColor = Color.FromArgb(255, 242, 208, 59);
                }
                else {
                    setDefaultColor(e.Item.SubItems[0]);
                    setDefaultColor(e.Item.SubItems[1]);
                    setDefaultColor(e.Item.SubItems[2]);

                    glacialList.SelectedTextColor = Color.FromArgb(255, 141, 151, 166);
                    glacialList.SelectionColor = Color.FromArgb(255, 29, 34, 41);
                }

            }
        }

        private void glacialListPath_ItemChangedEvent(object source, ChangedEventArgs e) {
            if (e.ChangedType == ChangedTypes.SelectionChanged || e.ChangedType == ChangedTypes.SubItemChanged) {
                if (e.Item.SubItems[0].Checked) {
                    setSelectedColor(e.Item.SubItems[0]);

                    glacialListPath.SelectedTextColor = Color.FromArgb(255, 36, 42, 52);
                    glacialListPath.SelectionColor = Color.FromArgb(255, 242, 208, 59);
                }
                else {
                    setDefaultColor(e.Item.SubItems[0]);

                    glacialListPath.SelectedTextColor = Color.FromArgb(255, 141, 151, 166);
                    glacialListPath.SelectionColor = Color.FromArgb(255, 29, 34, 41);
                }
            }
        }

        private void onButtonClick(object sender, EventArgs e) {
            if (isRunning) return;
            Button btn = (Button)sender;

            switch (btn.Text) {
                case "Select All":
                    Console.WriteLine("SA");
                    foreach (GLItem item in glacialList.Items) {
                        item.SubItems[0].Checked = true;
                    }
                    break;
                case "Invert":
                    Console.WriteLine("Invert");
                    foreach (GLItem item in glacialList.Items) {
                        item.SubItems[0].Checked = !item.SubItems[0].Checked;
                    }

                    foreach (GLItem item in glacialList.Items) {
                        if (item.Selected) {
                            if (item.SubItems[0].Checked) {
                                glacialList.SelectedTextColor = Color.FromArgb(255, 36, 42, 52);
                                glacialList.SelectionColor = Color.FromArgb(255, 242, 208, 59);
                            }
                            else {
                                glacialList.SelectedTextColor = Color.FromArgb(255, 141, 151, 166);
                                glacialList.SelectionColor = Color.FromArgb(255, 29, 34, 41);
                            }
                        }
                    }
                    break;
                case "Clear":
                    Console.WriteLine("clear");
                    foreach (GLItem item in glacialList.Items)
                        item.SubItems[0].Checked = false;
                    break;
                case "Remove":
                    for (int i = 0; i < glacialList.Items.Count; i++) {
                        GLItem item = glacialList.Items[i];
                        if (item.SubItems[0].Checked) {
                            glacialList.Items.RemoveAt(i);
                            i = -1;
                        }
                    }
                    LabelHint.Visible = (glacialList.Items.Count == 0);
                    glacialList.Refresh();

                    break;
                case "Remove All":
                    glacialList.Items.Clear();
                    glacialList.Refresh();
                    removeWatch();
                    setStatus("Watch removed.", 0);
                    LabelHint.Visible = true;
                    break;
            }
        }

        private void openFolder(object sender, EventArgs e) {
            if (isRunning) return;

            Control btn = (Control)sender;

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            switch (btn.Name) {
                case "pathLabel":
                case "btnOpenPath":
                    fbd.ShowDialog();

                    if (!string.IsNullOrWhiteSpace(fbd.SelectedPath)) {

                        string[] files = Directory.GetFiles(fbd.SelectedPath);
                        string[] dir = Directory.GetDirectories(fbd.SelectedPath);

                        addFilesToList(dir);
                        addFilesToList(files);
                        pathLabel.Text = fbd.SelectedPath.ToLower();

                        startWatch(fbd.SelectedPath);
                        watchPath = fbd.SelectedPath;
                        glacialList.Refresh();

                        LabelHint.Visible = (glacialList.Items.Count == 0);
                    }

                    break;
                case "btnAddDestPath":
                    if (pastebox.Text != pastehinttext)
                        onPasteBtn(this, null);
                    else {
                        fbd.ShowDialog();

                        if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            addDestPath(fbd.SelectedPath);
                            glacialListPath.Refresh();
                        }
                    }
                    break;
            }
        }

        public void addFilesToList(string[] files) {
            int c = 0;
            foreach (string filePath in files) {
                if (hasThisFile(filePath)) { continue; }
                if (hasThisInPath(filePath)) {
                    setStatus(Path.GetFileName(filePath) + ". Folder already in destination path", 2);
                    continue;
                }

                GLItem item = glacialList.Items.Add(Path.GetFileName(filePath));
                item.ForeColor = Color.FromArgb(255, 141, 151, 166);
                item.SubItems[0].ForeColor = Color.FromArgb(255, 141, 151, 166);
                item.SubItems[0].Checked = true;

                item.SubItems[1].Text = filePath;
                item.SubItems[1].ForeColor = Color.FromArgb(255, 141, 151, 166);

                item.SubItems[2].Text = Path.GetExtension(filePath);
                item.SubItems[2].ForeColor = Color.FromArgb(255, 141, 151, 166);

                c++;
            }

            if (c > 0) LabelHint.Visible = false;
            setStatus("File(s) added: " + c, 0);
        }

        private bool hasThisInPath(string path) {
            if (glacialListPath.Items.Count == 0) return false;

            foreach (GLItem item in glacialListPath.Items) {
                if (item.SubItems[0].Text == path)
                    return true;
            }

            return false;
        }

        private void closeApp(object sender, EventArgs e) {
            Application.Exit();
        }

        private void onPaint(object sender, PaintEventArgs e) {
            Panel p = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.FromArgb(255, 49, 54, 61), ButtonBorderStyle.Solid);
        }

        private void onPanelResize(object sender, EventArgs e) {
            Invalidate();
        }

        private void clearWatchPath(object sender, EventArgs e) {
            removeWatch();
            setStatus("Watch removed.", 0);
        }

        private void onPathButton(object sender, EventArgs e) {
            if (isRunning) return;
            Button btn = (Button)sender;

            switch (btn.Name) {
                case "btnRem":
                    for (int i = 0; i < glacialListPath.Items.Count; i++) {
                        GLItem item = glacialListPath.Items[i];
                        if (item.SubItems[0].Checked) {
                            glacialListPath.Items.RemoveAt(i);
                            glacialListPath.Refresh();
                            i = -1;
                        }
                    }

                    glacialListPath.Refresh();

                    break;
                case "btnRemAll":
                    glacialListPath.Items.Clear();
                    glacialListPath.Refresh();
                    break;
            }
        }

        public void doCopy(object sender, EventArgs e) {
            if (isRunning) return;
            new Thread(new ThreadStart(startCopy)).Start();
        }

        private void startCopy() {
            int tickCount = 0;

            foreach (GLItem item in glacialList.Items)
                if (item.SubItems[0].Checked) tickCount++;

            if (glacialListPath.Items.Count == 0) {
                setStatus("Your life is pointless, so are your files.", 2);
                return;
            }

            if (glacialList.Items.Count == 0 && !autoCheck.Checked) {
                setStatus("You have nothing in your life, not even a mere file.", 2);
                return;
            }

            if (tickCount == 0 && !autoCheck.Checked) {
                setStatus("Uhh... what is your plan exactly?", 2);
                return;
            }

            isRunning = true;
            mm.copyStart();

            foreach (GLItem path in glacialListPath.Items) {
                float count = getFileCount();
                int completed = 0;

                if (!path.SubItems[0].Checked) continue;

                setStatus("Copying: 0%", 1);

                foreach (GLItem item in glacialList.Items) {
                    if (!item.SubItems[0].Checked) continue;

                    string filename = item.SubItems[0].Text;
                    string sourcePath = item.SubItems[1].Text;
                    string destPath = path.SubItems[0].Text;
                    string destFile = Path.Combine(path.SubItems[0].Text, filename);
                    //string sourceFilename = Path.Combine(sourcePath, filename);

                    try {
                        if (!Directory.Exists(destPath)) Directory.CreateDirectory(destPath);
                        if (File.GetAttributes(sourcePath).HasFlag(FileAttributes.Directory))
                            copyDirectory(sourcePath, destFile);
                        else File.Copy(sourcePath, destFile, true);

                        if (deselectCheck.Checked && !cutmode.Checked) {
                            Invoke((MethodInvoker) delegate { item.SubItems[0].Checked = false; });
                        }

                        completed++;
                        float progress = (completed / count) * 100;
                        setStatus("Copying: " + progress.ToString("0.00") + "%", 1);
                    }
                    catch (UnauthorizedAccessException ex) {
                        MessageBox.Show("Access error: " + filename, "Error");
                        setStatus("Failure. Unable to write " + filename + ". You are. Process terminated.", 2);
                        isRunning = false;
                        autoCheck.Checked = false;
                        mm.copyEnd();
                        return;
                    }
                    catch (ArgumentException ex) {
                        MessageBox.Show("Invalid path.", "Error");
                        setStatus("Process terminated.", 2);
                        isRunning = false;
                        autoCheck.Checked = false;
                        mm.copyEnd();
                        return;
                    }
                    catch (IOException ex) {
                        MessageBox.Show("Unknown error. Check source path", "Error");
                        setStatus("Unknown error. Check source path", 2);
                        isRunning = false;
                        autoCheck.Checked = false;
                        mm.copyEnd();
                        return;
                    }
                }
            }

            setStatus("Most probably it is a success.", 1);

            if (cutmode.Checked) {
                deleteFiles();
                glacialList.Refresh();
            }

            isRunning = false;
            mm.copyEnd();
        }

        private void deleteFiles() {
            try {
                foreach (GLItem item in glacialList.Items) {
                    if (item.SubItems[0].Checked) {
                        var path = item.SubItems[1].Text;

                        if (File.GetAttributes(path).HasFlag(FileAttributes.Directory))
                            Directory.Delete(path);
                        else File.Delete(path);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            checkExistence();
        }

        private void deleteFile(GLItem item) {
            File.Delete(item.SubItems[1].Text);
            glacialList.Items.Remove(item);
        }

        private void addDestPath(string path) {
            if (hasThisPath(path)) return;

            try {
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            }
            catch (ArgumentException ex) {
                MessageBox.Show("Invalid path.", "Error");
                setStatus("Process terminated.", 2);
                isRunning = false;
                autoCheck.Checked = false;
                mm.copyEnd();
                return;
            }
            catch (IOException ex) {
                MessageBox.Show("Unknown error. Check source path", "Error");
                setStatus("Unknown error. Check source path", 2);
                isRunning = false;
                autoCheck.Checked = false;
                mm.copyEnd();
                return;
            }

            GLItem item = new GLItem();
            item.ForeColor = Color.FromArgb(255, 141, 151, 166);
            item.SubItems[0].Text = path;
            item.SubItems[0].ForeColor = Color.FromArgb(255, 141, 151, 166);
            glacialListPath.Items.Add(item);

            item.SubItems[0].Checked = true;
        }

        private int getFileCount() {
            int count = 0;

            foreach (GLItem item in glacialList.Items)
                if (item.SubItems[0].Checked) count++;
            return count;
        }

        private void copyDirectory(string Src, string Dst) {
            String[] Files;

            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)
                Dst += Path.DirectorySeparatorChar;

            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);

            Files = Directory.GetFileSystemEntries(Src);

            float count = Files.Length;
            int completed = 0;

            foreach (string Element in Files) {
                // Sub directories
                if (Directory.Exists(Element))
                    copyDirectory(Element, Dst + Path.GetFileName(Element));
                // Files in directory
                else
                    File.Copy(Element, Dst + Path.GetFileName(Element), true);

                completed++;
                float progress = (completed / count) * 100;
                setStatus("Copying: " + progress.ToString("0.00") + "%", 1);
            }
        }

        private void onCutChecked(object sender, EventArgs e) {
            btnCopy.Text = (cutmode.Checked) ? "MOVE" : "COPY";
        }

        private void doMinimize(object sender, EventArgs e) {
             this.WindowState = FormWindowState.Minimized;
        }

        private void writeObject(GLItemCollection items, bool isSource) {
            ArrayList objects = new ArrayList(items.Count);

            foreach (GLItem item in items) {
                FileObject f = new FileObject();

                if (isSource) {
                    f.Name = item.SubItems[0].Text;
                    f.Path = item.SubItems[1].Text;
                    f.Ext = item.SubItems[2].Text;
                    f.isSelected = item.SubItems[0].Checked;
                }
                else {
                    f.Path = item.SubItems[0].Text;
                    f.isSelected = item.SubItems[0].Checked;
                }

                objects.Add(f);
            }

            string path = Path.Combine(userPath, (isSource) ? "source.dat" : "dest.dat");

            FileStream fs = null;
            BinaryFormatter bf = new BinaryFormatter();
            try {
                fs = new FileStream(path, FileMode.Create);
                bf.Serialize(fs, objects);
            }
            catch (SerializationException ex) {
                setStatus("Write error.", 2);
            }
            catch (IOException ex) {
                Console.WriteLine(ex.Message);
            }
            finally {
                if (fs != null) fs.Close();
            }
        }

        private void readObject(bool isSource) {
            ArrayList objects;
            string path = Path.Combine(userPath, (isSource) ? "source.dat" : "dest.dat");

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = null;

            try {
                if (!Directory.Exists(userPath)) Directory.CreateDirectory(userPath);
                fs = new FileStream(path, FileMode.Open);
                objects = (ArrayList)bf.Deserialize(fs);
                fs.Close();
            }
            catch (IOException ex) {
                Console.WriteLine("No pref.");
                if (fs != null) fs.Close();
                return;
            }

            if (isSource) {
                glacialList.Items.Clear();

                foreach (FileObject f in objects) {
                    GLItem i = new GLItem();
                    i.SubItems[0].Text = f.Name;
                    i.SubItems[1].Text = f.Path;
                    i.SubItems[2].Text = f.Ext;
                    i.ForeColor = Color.FromArgb(255, 141, 151, 166);

                    if (f.isSelected) {
                        setSelectedColor(i.SubItems[0]);
                        setSelectedColor(i.SubItems[1]);
                        setSelectedColor(i.SubItems[2]);
                    }
                    else {
                        setDefaultColor(i.SubItems[0]);
                        setDefaultColor(i.SubItems[1]);
                        setDefaultColor(i.SubItems[2]);
                    }

                    glacialList.Items.Add(i);
                    i.SubItems[0].Checked = f.isSelected;
                }

                LabelHint.Visible = glacialList.Items.Count == 0;
                glacialList.Refresh();
            }
            else {
                glacialListPath.Items.Clear();

                foreach (FileObject f in objects) {
                    GLItem i = new GLItem();
                    i.SubItems[0].Text = f.Path;

                    glacialListPath.Items.Add(i);
                    i.SubItems[0].Checked = f.isSelected;

                    i.ForeColor = Color.FromArgb(255, 141, 151, 166);
                    if (f.isSelected) setSelectedColor(i.SubItems[0]);
                    else setDefaultColor(i.SubItems[0]);

                }

                glacialListPath.Refresh();
            }
        }

        private void onClosing(object sender, FormClosingEventArgs e) {
            writeObject(glacialList.Items, true);
            writeObject(glacialListPath.Items, false);

            Console.WriteLine("Content saved.");
        }

        private void doMiniMode(object sender, EventArgs e) {
            int sw = Screen.FromControl(this).WorkingArea.Width;
            int sh = Screen.FromControl(this).WorkingArea.Height;

            mm.TopMost = true;
            mm.StartPosition = FormStartPosition.Manual;
            mm.DesktopLocation = new Point(sw - mm.Size.Width - 8, sh - mm.Size.Height - 8);
            mm.Show();

            deselectMode = deselectCheck.Checked;
            deselectCheck.Checked = false;

            Hide();
        }

        private void onFormShow(object sender, EventArgs e) {
            deselectCheck.Checked = deselectMode;
        }

        private void onPasteAccept(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                onPasteBtn(this, null);
        }

        private void onClearPaste(object sender, EventArgs e) {
            pastebox.Clear();
            pastebox.Text = pastehinttext;
        }

        private void onPasteBtn(object sender, EventArgs e) {
            if (isRunning) return;

            if (pastebox.Text != pastehinttext) {
                addDestPath(pastebox.Text);
                glacialListPath.Refresh();

                pastebox.Text = pastehinttext;
            }
        }

        private void onClickPastebox(object sender, EventArgs e) {
            if (pastebox.Text == pastehinttext) {
                pastebox.SelectAll();
            }
        }

        private void onPasteTextChange(object sender, EventArgs e) {
            if (pastebox.Text == "") pastebox.Text = pastehinttext;
        }

        private void onPasteboxFocusLeave(object sender, EventArgs e) {
            pastebox.SelectionLength = 0;
        }

        private void onPrefClick(object sender, EventArgs e) {
            int fx = DesktopLocation.X;
            int fy = DesktopLocation.Y;

            pref.StartPosition = FormStartPosition.Manual;
            pref.DesktopLocation = new Point(fx + Size.Width + 8, fy);
            pref.Show();
        }

        private void startListener() {

            client = new XDMessagingClient();
            listener = client.Listeners.GetWindowsMessagingListener();
            listener.RegisterChannel(channelName);

            listener.MessageReceived += (o, e) => {

                if (e.DataGram.Channel == channelName) {

                    TypedDataGram<IEnumerable<string>> obj = e.DataGram;

                    int len = obj.Message.Count();
                    int i = 0;

                    string[] files = new string[len];

                    foreach (string s in obj.Message) {
                        files[i] = s;
                        i++;
                    }

                    addFilesToList(files);
                    glacialList.Refresh();
                }
            };
        }

        private void onFocusEnter(object sender, EventArgs e) {
//            //Notify MetaCopy is running.
//            XDMessagingClient client = new XDMessagingClient();
//            IXDBroadcaster broadcaster = client.Broadcasters.GetWindowsMessagingBroadcaster();
//            broadcaster.SendToChannel("MetaStartChannel", "ProcessStarted");
//
//            startListener();
        }
    }
}