using System;
using System.Windows.Forms;

namespace Gazer
{
    static class Program
    {
        public static string Date = "16.02.2018";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
