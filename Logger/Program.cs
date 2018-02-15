using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Logger
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Не позволяем запускать приложение повторно
            //Возможно неуловимая ошибка из-за этого и появляется
            int count = 0;
            foreach (Process pr in Process.GetProcesses())
                if (pr.ProcessName == "Gazer Logger") count++;
            if (count > 1)
            {
                MessageBox.Show("Приложение уже запущено");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
