using System;
using System.Windows.Forms;

namespace Simple_Backuper.app
{
    static class Start
    {
        // Import dll to make process dpi aware
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetProcessDPIAware();

        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BackupForm());
        }
    }
}
