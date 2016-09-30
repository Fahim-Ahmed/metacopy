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

            FileObject fo = new FileObject("bleh", "x:/asdsa/asds", false);
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

                    GLSubItem si = item.SubItems[0];
                    si.ChangedEvent += (source, args) =>{
                        GLSubItem sub = (GLSubItem) source;
                        Console.WriteLine(sub.Checked);
                    };

                    item.SubItems[1].Text = filePath;
                    item.SubItems[1].ForeColor = Color.FromArgb(255, 141, 151, 166);
                }
            }
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
    }
}
