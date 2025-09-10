using System;
using System.Windows.Forms;

namespace Kasir
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Jalankan Form2 (Login) terlebih dahulu
            Application.Run(new Form2());
        }
    }
}
