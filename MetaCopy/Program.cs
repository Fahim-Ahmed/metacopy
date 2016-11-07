using System;
using System.Threading;
using System.Windows.Forms;

namespace MetaCopy
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{5DA59A77-C4C8-42D5-A739-37B0075DD116}");

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
