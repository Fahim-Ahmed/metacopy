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
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;
using GlacialComponents.Controls;

namespace MetaCopy
{
    public partial class Form1 : Form //: MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            borderedPanel1.hideTextbox();
            glacialList.BringToFront();
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
                foreach (string filePath in files){
                    GLItem item = glacialList.Items.Add(Path.GetFileName(filePath));
                    item.ForeColor = Color.FromArgb(255, 141, 151, 166);
                    item.SubItems[0].ForeColor = Color.FromArgb(255, 141, 151, 166);
               //     item.SubItems[0].Checked = true;
                    
                    item.SubItems[1].Text = filePath;
                    item.SubItems[1].ForeColor = Color.FromArgb(255, 141, 151, 166);
                }
            }
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

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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
    }
}
