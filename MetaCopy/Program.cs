using System;
using System.Threading;
using System.Windows.Forms;

namespace MetaCopy
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{8ED6F2DD-F07F-437D-B993-52D8BF249201}");

        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true)) {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());

                mutex.ReleaseMutex();
            }
            else {
                NativeMethods.PostMessage((IntPtr)NativeMethods.HWND_BROADCAST,
                            NativeMethods.WM_SHOWME,
                            IntPtr.Zero,
                            IntPtr.Zero);
            }
        }
    }
}
