using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Windows.Forms;
using SharpShell.Diagnostics;
using SharpShell.ServerRegistration;

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

        private MetaCopyExt server;

        public PrefWindow() {
            InitializeComponent();
            server = new MetaCopyExt();
        }

//        public void setServer(MetaCopyExt ext){
//            this.server = ext;
//        }

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
            this.Hide();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = @"BUILTIN\Administrators")]
        private void onRegisterBtn(object sender, EventArgs e) {
            try {
                if (InternalCheckIsWow64()) {
                    ServerRegistrationManager.InstallServer(server, RegistrationType.OS64Bit, true);
                    ServerRegistrationManager.RegisterServer(server, RegistrationType.OS64Bit);
                }
                else {
                    ServerRegistrationManager.InstallServer(server, RegistrationType.OS32Bit, true);
                    ServerRegistrationManager.RegisterServer(server, RegistrationType.OS32Bit);
                }

                this.Hide();

                ExplorerManager.RestartExplorer();
            } catch (Exception ex) {
                MessageBox.Show("Require admin access.");
            }
            
        }

        [PrincipalPermission(SecurityAction.Demand, Role = @"BUILTIN\Administrators")]
        private void onDeregisterBtn(object sender, EventArgs e) {
            try {
                if (InternalCheckIsWow64()) {
                    ServerRegistrationManager.UnregisterServer(server, RegistrationType.OS64Bit);
                    ServerRegistrationManager.UninstallServer(server, RegistrationType.OS64Bit);
                }
                else {
                    ServerRegistrationManager.UnregisterServer(server, RegistrationType.OS32Bit);
                    ServerRegistrationManager.UninstallServer(server, RegistrationType.OS32Bit);
                }

                this.Hide();

                ExplorerManager.RestartExplorer();
            }
            catch (Exception ex) {
                MessageBox.Show("Require admin access.");
            }
        }

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWow64Process(
            [In] IntPtr hProcess,
            [Out] out bool wow64Process
        );

        public static bool InternalCheckIsWow64() {
            if ((Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1) ||
                Environment.OSVersion.Version.Major >= 6) {
                using (Process p = Process.GetCurrentProcess()) {
                    bool retVal;
                    if (!IsWow64Process(p.Handle, out retVal)) {
                        return false;
                    }
                    return retVal;
                }
            }

            return false;
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
