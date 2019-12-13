using MachineRepairScheduler.Desktop.Forms;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                if (((Exception)e.ExceptionObject).InnerException is HttpRequestException)
                    MessageBox.Show("Could not connect to the server. Application will close.", "Connection problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Following error has occured: {((Exception)e.ExceptionObject).Message}. Application will close.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Environment.Exit(-1);
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BackgroundForm());
        }
    }
}
