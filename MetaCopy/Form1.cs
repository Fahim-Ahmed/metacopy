using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using GlacialComponents.Controls;

namespace MetaCopy
{
    public partial class Form1 : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private FileSystemWatcher watcher;
        private string watchPath;

        public Form1()
        {
            InitializeComponent();

            glacialList.BringToFront();
            glacialListPath.BringToFront();

            watcher = new FileSystemWatcher();
        }

        private void startWatch(string path)
        {
            watcher.Path = path;
            watcher.NotifyFilter = NotifyFilters.Size | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.*";
            watcher.Changed += OnDirectoryChanged;
            watcher.Deleted += OnDirectoryChanged;
            watcher.Created += OnDirectoryChanged;
            watcher.Renamed += OnDirectoryChanged;
            watcher.EnableRaisingEvents = true;
        }

        private void removeWatch(){
            watcher.Changed -= OnDirectoryChanged;
            watcher.Deleted -= OnDirectoryChanged;
            watcher.Created -= OnDirectoryChanged;
            watcher.Renamed -= OnDirectoryChanged;

            pathLabel.Text = "add a watch folder";
        }

        private void checkExistence(){
            for(int i = 0; i < glacialList.Items.Count; i++){
                GLItem item = glacialList.Items[i];
                string path = item.SubItems[1].Text;

                if (!File.Exists(item.SubItems[1].Text)){

                    try{
                        if (File.GetAttributes(path).HasFlag(FileAttributes.Directory)){
                            //Exist
                            continue;
                        }
                    }
                    catch (FileNotFoundException ex){
                        //Don't exist
                        Console.WriteLine(ex.Message);
                    }

                    glacialList.Items.Remove(item);
                    glacialList.Refresh();
                    i = 0;
                }
            }
        }

        private void OnDirectoryChanged(object sender, FileSystemEventArgs e){
            addFilesToList(Directory.GetDirectories(watchPath));
            addFilesToList(Directory.GetFiles(watchPath));
            checkExistence();

            setStatus("Directory structure changed. File list updated.", 1);
        }

        void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
                addFilesToList(files);
            }
        }

        private bool hasThisFile(string path)
        {
            if (glacialList.Items.Count == 0) return false;

            foreach (GLItem item in glacialList.Items)
            {
                if (item.SubItems[1].Text == path)
                    return true;
            }

            return false;
        }

        private bool hasThisPath(string path)
        {
            if (glacialListPath.Items.Count == 0) return false;

            foreach (GLItem item in glacialListPath.Items)
            {
                if (item.SubItems[0].Text == path)
                    return true;
            }

            return false;
        }

        private void setSelectedColor(GLSubItem sub){
            sub.ForeColor = Color.FromArgb(255, 36, 42, 52);
            sub.BackColor = Color.FromArgb(255, 242, 208, 59);
        }

        private void setDefaultColor(GLSubItem sub)
        {
            sub.ForeColor = Color.FromArgb(255, 141, 151, 166);
            sub.BackColor = Color.FromArgb(255, 29, 34, 41);
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void setStatus(string msg, int type)
        {
            switch (type)
            {
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

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void glacialList_ItemChangedEvent(object source, ChangedEventArgs e){
            if (e.ChangedType == ChangedTypes.SelectionChanged || e.ChangedType == ChangedTypes.SubItemChanged){
                if (e.Item.SubItems[0].Checked){
                    setSelectedColor(e.Item.SubItems[0]);
                    setSelectedColor(e.Item.SubItems[1]);

                    glacialList.SelectedTextColor = Color.FromArgb(255, 36, 42, 52);
                    glacialList.SelectionColor = Color.FromArgb(255, 242, 208, 59);
                }
                else{
                    setDefaultColor(e.Item.SubItems[0]);
                    setDefaultColor(e.Item.SubItems[1]);

                    glacialList.SelectedTextColor = Color.FromArgb(255, 141, 151, 166);
                    glacialList.SelectionColor = Color.FromArgb(255, 29, 34, 41);
                }
            }
        }

        private void glacialListPath_ItemChangedEvent(object source, ChangedEventArgs e) {
            if (e.ChangedType == ChangedTypes.SelectionChanged || e.ChangedType == ChangedTypes.SubItemChanged) {
                if (e.Item.SubItems[0].Checked) {
                    setSelectedColor(e.Item.SubItems[0]);
                    setSelectedColor(e.Item.SubItems[1]);

                    glacialListPath.SelectedTextColor = Color.FromArgb(255, 36, 42, 52);
                    glacialListPath.SelectionColor = Color.FromArgb(255, 242, 208, 59);
                }
                else {
                    setDefaultColor(e.Item.SubItems[0]);
                    setDefaultColor(e.Item.SubItems[1]);

                    glacialListPath.SelectedTextColor = Color.FromArgb(255, 141, 151, 166);
                    glacialListPath.SelectionColor = Color.FromArgb(255, 29, 34, 41);
                }
            }
        }

        private void onButtonClick(object sender, EventArgs e){
            Button btn = (Button) sender;

            switch (btn.Text){
                case "Select All":
                    Console.WriteLine("SA");
                    foreach (GLItem item in glacialList.Items){
                        item.SubItems[0].Checked = true;
                    }
                    break;
                case "Invert":
                    Console.WriteLine("Invert");
                    foreach (GLItem item in glacialList.Items)
                    {
                        item.SubItems[0].Checked = !item.SubItems[0].Checked;
                    }

                    foreach (GLItem item in glacialList.Items)
                    {
                        if (item.Selected){
                            if (item.SubItems[0].Checked){
                                glacialList.SelectedTextColor = Color.FromArgb(255, 36, 42, 52);
                                glacialList.SelectionColor = Color.FromArgb(255, 242, 208, 59);
                            }
                            else{
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
                    for (int i = 0; i < glacialList.Items.Count; i++){
                        GLItem item = glacialList.Items[i];
                        if (item.SubItems[0].Checked){
                            glacialList.Items.RemoveAt(i);
                            i = 0;
                        }
                    }

                    if (glacialList.Items.Count > 0)
                        if (glacialList.Items[0].SubItems[0].Checked == true) glacialList.Items.RemoveAt(0);

                    glacialList.Refresh();

                    break;
                case "Remove All":
                    glacialList.Items.Clear();
                    glacialList.Refresh();
                    removeWatch();
                    setStatus("Watch removed.", 0);
                    break;
            }
        }

        private void openFolder(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                string[] dir = Directory.GetDirectories(fbd.SelectedPath);

                //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");

                Control btn = (Control) sender;

                switch (btn.Name){
                    case "pathLabel":
                    case "btnOpenPath":
                        addFilesToList(dir);
                        addFilesToList(files);
                        pathLabel.Text = fbd.SelectedPath.ToLower();

                        startWatch(fbd.SelectedPath);
                        watchPath = fbd.SelectedPath;

                        break;
                    case "btnAddDestPath":
                        if (hasThisPath(fbd.SelectedPath)) break;

                        GLItem item = new GLItem();
                        item.ForeColor = Color.FromArgb(255, 141, 151, 166);
                        item.SubItems[0].Text = fbd.SelectedPath;
                        item.SubItems[0].ForeColor = Color.FromArgb(255, 141, 151, 166);
                        glacialListPath.Items.Add(item);

                        item.SubItems[0].Checked = true;
                        glacialListPath.Refresh();
                        break;
                }
            }
        }

        public void addFilesToList(string[] files){
            foreach (string filePath in files)
            {
                if (hasThisFile(filePath)) continue;

                GLItem item = glacialList.Items.Add(Path.GetFileName(filePath));
                item.ForeColor = Color.FromArgb(255, 141, 151, 166);
                item.SubItems[0].ForeColor = Color.FromArgb(255, 141, 151, 166);
                item.SubItems[0].Checked = true;

                item.SubItems[1].Text = filePath;
                item.SubItems[1].ForeColor = Color.FromArgb(255, 141, 151, 166);
            }
        }

        private void closeApp(object sender, EventArgs e) {
            Application.Exit();
        }

        private void onPaint(object sender, PaintEventArgs e){
            Panel p = (Panel) sender;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.FromArgb(255, 49, 54, 61), ButtonBorderStyle.Solid);
        }

        private void onPanelResize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void clearWatchPath(object sender, EventArgs e){
            removeWatch();
            setStatus("Watch removed.", 0);
        }

        private void onPathButton(object sender, EventArgs e){
            Button btn = (Button) sender;

            switch (btn.Name){
                case "btnRem":
                    for (int i = 0; i < glacialListPath.Items.Count; i++)
                    {
                        GLItem item = glacialListPath.Items[i];
                        if (item.SubItems[0].Checked)
                        {
                            glacialListPath.Items.RemoveAt(i);
                            glacialListPath.Refresh();
                            i = 0;
                        }
                    }

                    if (glacialListPath.Items.Count > 0)
                        if(glacialListPath.Items[0].SubItems[0].Checked == true) glacialListPath.Items.RemoveAt(0);

                    glacialListPath.Refresh();

                    break;
                case "btnRemAll":
                    glacialListPath.Items.Clear();
                    glacialListPath.Refresh();
                    break;
            }
        }

        private void doCopy(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(startCopy)).Start();
        }

        private void startCopy()
        {
            int tickCount = 0;
            foreach (GLItem item in glacialList.Items)
                if (item.SubItems[0].Checked) tickCount++;

            if (glacialListPath.Items.Count == 0)
                setStatus("Your life is pointless, so are your files.", 2);
            else if (glacialList.Items.Count == 0)
                setStatus("You have nothing in your life, not even a mere file.", 2);
            else if (tickCount == 0)
                setStatus("Uhh... what is your plan exactly?", 2);

            foreach (GLItem path in glacialListPath.Items) {
                float progress = 0;
                float count = getFileCount();
                int completed = 0;

                setStatus("Copying: 0%", 1);

                foreach (GLItem item in glacialList.Items) {
                    if (!item.SubItems[0].Checked) continue;

                    string filename = item.SubItems[0].Text;
                    string sourcePath = item.SubItems[1].Text;
                    string destPath = path.SubItems[0].Text;
                    string destFile = Path.Combine(path.SubItems[0].Text, filename);
                    //string sourceFilename = Path.Combine(sourcePath, filename);

                    try
                    {
                        if (!Directory.Exists(destPath)) Directory.CreateDirectory(destPath);
                        if (File.GetAttributes(sourcePath).HasFlag(FileAttributes.Directory))
                            copyDirectory(sourcePath, destFile);
                        else File.Copy(sourcePath, destFile, true);

                        completed++;
                        progress = (completed/count)*100;
//                        this.Invoke((MethodInvoker) delegate {
                        setStatus("Copying: " + progress.ToString("0.00") + "%", 1);
//                        });

                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        MessageBox.Show("Access error: " + filename, "Error");
                        setStatus("Failure. Unable to write " + filename + ". You are. Process terminated.", 2);
                        return;
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show("Invalid path.", "Error");
                        setStatus("Process terminated.", 2);
                        return;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Unknown error. Check source path", "Error");
                        setStatus("Unknown error. Check source path", 2);
                        return;
                    }
                }
            }

            setStatus("Most probably it is a success.", 1);
        }

        private int getFileCount(){
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

            foreach (string Element in Files) {
                // Sub directories
                if (Directory.Exists(Element))
                    copyDirectory(Element, Dst + Path.GetFileName(Element));
                // Files in directory
                else
                    File.Copy(Element, Dst + Path.GetFileName(Element), true);
            }
        }

    }
}