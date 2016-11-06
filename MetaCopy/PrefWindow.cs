using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MetaCopy {

    [RegistryPermission(SecurityAction.Demand, Unrestricted = true)]
    public partial class PrefWindow : Form {

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private RegistryKey regMenu;
        private RegistryKey regCmd;
        private string menuName = "Folder\\shell\\MetaCopy";
        private string menuCmd = "Folder\\shell\\MetaCopy\\command";
        private string menuValue = "Add to MetaCopy";

        public PrefWindow() {
            InitializeComponent();
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



        private void onCloseBtn(object sender, EventArgs e) {
            Hide();
        }

        private void onRegisterBtn(object sender, EventArgs e){
            try{
                CheckSecurity();

                regMenu = Registry.ClassesRoot.CreateSubKey(menuName);
                if (regMenu != null) regMenu.SetValue("", menuValue);

                regCmd = Registry.ClassesRoot.CreateSubKey(menuCmd);
                if (regCmd != null) regCmd.SetValue("", Application.ExecutablePath + " %1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
            finally
            {
                if (regMenu != null)
                    regMenu.Close();
                if (regCmd != null)
                    regCmd.Close();
            }
        }

        private void onDeregisterBtn(object sender, EventArgs e)
        {
            try{
                RegistryKey reg = Registry.ClassesRoot.OpenSubKey(menuCmd);
                if (reg != null){
                    reg.Close();
                    Registry.ClassesRoot.DeleteSubKey(menuCmd);
                }

                reg = Registry.ClassesRoot.OpenSubKey(menuName);
                if (reg != null){
                    reg.Close();
                    Registry.ClassesRoot.DeleteSubKey(menuName);
                }
            }
            catch (Exception ex){
                MessageBox.Show(this, ex.ToString());
            }
        }

        private void CheckSecurity(){
            //check registry permissions
            RegistryPermission regPerm;
            regPerm = new RegistryPermission(RegistryPermissionAccess.Write, "HKEY_CLASSES_ROOT\\" + menuName);
            regPerm.AddPathList(RegistryPermissionAccess.Write, "HKEY_CLASSES_ROOT\\" + menuCmd);
            regPerm.Demand();

        }

        //FOR GROUP BOX
        //        private void PaintBorderlessGroupBox(object sender, PaintEventArgs e) {
        //            GroupBox box = sender as GroupBox;
        //            DrawGroupBox(box, e.Graphics, Color.FromArgb(141, 151, 166), Color.FromArgb(141, 151, 166));
        //        }
        //
        //        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor) {
        //            if (box != null) {
        //                Brush textBrush = new SolidBrush(textColor);
        //                Brush borderBrush = new SolidBrush(borderColor);
        //                Pen borderPen = new Pen(borderBrush);
        //                SizeF strSize = g.MeasureString(box.Text, box.Font);
        //                Rectangle rect = new Rectangle(box.ClientRectangle.X,
        //                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
        //                                               box.ClientRectangle.Width - 1,
        //                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);
        //
        //                // Clear text and border
        //                g.Clear(this.BackColor);
        //
        //                // Draw text
        //                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);
        //
        //                // Drawing Border
        //                //Left
        //                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
        //                //Right
        //                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
        //                //Bottom
        //                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
        //                //Top1
        //                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
        //                //Top2
        //                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
        //            }
        //        }
    }
}
