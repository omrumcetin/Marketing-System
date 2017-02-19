using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SM
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Marjisoft"))
            {
                if (key != null)
                {
                    object o = key.GetValue("Key");
                    if (o.ToString() == "1229501630935818858")
                    {
                        Application.Run(new MainWindow());
                    }
                    else
                    {
                        MessageBox.Show("Lütfen iletişime geçiniz : Ömrüm Çetin +90 532 058 08 71");
                    }
                }
            }
            //if (DateTime.Now < DateTime.ParseExact("18.01.2017 00:00", "dd.MM.yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture))
            //    Application.Run(new MainWindow());
            //else
            //    MessageBox.Show("Uygulamanın süresi bitmiştir. Lütfen +90 532 058 0871 telefondan irtibata geçiniz");
        }
    }
}
