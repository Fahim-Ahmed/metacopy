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

        public Form1()
        {
            InitializeComponent();

            glacialList.BringToFront();
            glacialListPath.BringToFront();
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
                            glacialList.Refresh();
                            i = 0;
                        }
                    }
                    break;
                case "Remove All":
                    glacialList.Items.Clear();
                    glacialList.Refresh();
                    break;
            }
        }

        private void openFolder(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");

                Button btn = (Button) sender;

                switch (btn.Name){
                    case "btnOpenPath":
                        addFilesToList(files);
                        pathLabel.Text = fbd.SelectedPath.ToLower();
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
            pathLabel.Text = "add a watch folder";
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
                    break;
                case "btnRemAll":
                    glacialListPath.Items.Clear();
                    glacialListPath.Refresh();
                    break;
            }
        }
    }
}