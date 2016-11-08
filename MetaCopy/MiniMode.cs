using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MetaCopy {

    public partial class MiniMode : Form {
        private MetaCore mainForm;

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MiniMode() {
            InitializeComponent();
        }

        public void setMain(MetaCore form)
        {
            this.mainForm = form;
        }

        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void onPanelMouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        void panel_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void panel_DragDrop(object sender, DragEventArgs e) {
            mainForm.panel1_DragDrop(sender, e);
            if(mainForm.autoCheck.Checked) mainForm.doCopy(this, null);
        }

        private void doMaximize(object sender, EventArgs e) {
            Hide();
            mainForm.Show();
        }

        private void onCopyBtn(object sender, EventArgs e) {
            mainForm.doCopy(mainForm, e);
        }

        public void copyStart()
        {
            btnCopy.Text = "copying";
            btnCopy.backColor = Color.FromArgb(255, 27, 221, 151);
            btnCopy.BackColor = Color.FromArgb(255, 27, 221, 151);
            btnCopy.Enabled = false;
        }

        public void copyEnd()
        {
            btnCopy.Text = "COPY";
            btnCopy.Enabled = true;
            btnCopy.backColor = Color.FromArgb(255, 242, 208, 59);
            btnCopy.BackColor = Color.FromArgb(255, 242, 208, 59);
        }
    }
}
