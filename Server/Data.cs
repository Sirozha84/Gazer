using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace Server
{
    static class Data
    {
        static string UsersFile = "Users.txt";
        public static List<User> Users = new List<User>();
        static string CPFile = "CheckPoints.txt";
        public static List<CheckPoint> CheckPoints = new List<CheckPoint>();
        static string PropertiesFile = "Properties.txt";
        static string TempFile = "Temp.txt";
        //Параметры
        public static string photosDir = "";
        public static bool reportEnable = false;
        public static string reportFile = "";
        public static string reportCommand = "";
        public static bool timeOutTestEnable = false;
        public static int timeOutMinutes = 30;
        public static string timeOutCommand = "";
        //Данные для отчёта
        public static string curDate = "";
        public static int maxTime = 0;

        /// <summary>
        /// Загрузка списка пользователей из файла
        /// </summary>
        public static void LoadUsers()
        {
            try
            {
                using (TextReader file = File.OpenText(UsersFile))
                {
                    string n, k;
                    int t;
                    do
                    {
                        n = file.ReadLine();
                        t = Convert.ToInt32(file.ReadLine());
                        k = file.ReadLine();
                        if (k != null) Users.Add(new User(n, t, k));
                    } while (k != null);
                }
            }
            catch { }
        }

        /// <summary>
        /// Сохранение списка пользователей в файл
        /// </summary>
        public static void SaveUsers()
        {
            try
            {
                using (TextWriter file = File.CreateText(UsersFile))
                {
                    foreach (User u in Users)
                    {
                        file.WriteLine(u.Name);
                        file.WriteLine(u.Type);
                        file.WriteLine(u.Key);
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// Загрузка списка контрольных точек из файла
        /// </summary>
        public static void LoadCP()
        {
            try
            {
                using (TextReader file = File.OpenText(CPFile))
                {
                    string n, d, ip, l, p;
                    bool r, c;
                    do
                    {
                        n = file.ReadLine();
                        d = file.ReadLine();
                        r = Convert.ToBoolean(file.ReadLine());
                        c = Convert.ToBoolean(file.ReadLine());
                        ip = file.ReadLine();
                        l = file.ReadLine();
                        p = file.ReadLine();
                        if (p != null) CheckPoints.Add(new CheckPoint(n, d, r, c, ip, l, p));
                    } while (p != null);
                }
            }
            catch { }
        }

        /// <summary>
        /// Сохранение списка контрольных точек в файл
        /// </summary>
        public static void SaveCP()
        {
            try
            {
                using (TextWriter file = File.CreateText(CPFile))
                {
                    foreach (CheckPoint cp in CheckPoints)
                    {
                        file.WriteLine(cp.Name);
                        file.WriteLine(cp.Description);
                        file.WriteLine(cp.Result);
                        file.WriteLine(cp.Camera);
                        file.WriteLine(cp.IP);
                        file.WriteLine(cp.Login);
                        file.WriteLine(cp.Password);
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// Загрузка параметров хранилища
        /// </summary>
        public static void LoadProperties()
        {
            try
            {
                using (TextReader file = File.OpenText(PropertiesFile))
                {
                    //Папка
                    string s = file.ReadLine();
                    if (s != null) photosDir = s;
                    //Отчёт каждый день
                    s = file.ReadLine();
                    if (s != null) reportEnable = Convert.ToBoolean(s);
                    s = file.ReadLine();
                    if (s != null) reportFile = s;
                    s = file.ReadLine();
                    if (s != null) reportCommand = s;
                    //Проверка на простой
                    s = file.ReadLine();
                    if (s != null) timeOutTestEnable = Convert.ToBoolean(s);
                    s = file.ReadLine();
                    if (s != null) timeOutMinutes = Convert.ToInt32(s);
                    s = file.ReadLine();
                    if (s != null) timeOutCommand = s;
                }
            }
            catch { }
        }

        /// <summary>
        /// Сохранение параметров хранилища в файл
        /// </summary>
        public static void SaveProperties()
        {
            try
            {
                using (TextWriter file = File.CreateText(PropertiesFile))
                {
                    file.WriteLine(photosDir);
                    file.WriteLine(reportEnable);
                    file.WriteLine(reportFile);
                    file.WriteLine(reportCommand);
                    file.WriteLine(timeOutTestEnable);
                    file.WriteLine(timeOutMinutes);
                    file.WriteLine(timeOutCommand);
                }
            }
            catch { }
        }

        /// <summary>
        /// Загрузка данных из временного файла
        /// </summary>
        public static void LoadTemp()
        {
            try
            {
                using (TextReader file = File.OpenText(TempFile))
                {
                    string s = file.ReadLine();
                    if (s != null) curDate = s;
                    s = file.ReadLine();
                    if (s != null) maxTime = Convert.ToInt32(s);
                }
            }
            catch { }
        }

        /// <summary>
        /// Сохранение данных во временный файл
        /// </summary>
        public static void SaveTemp()
        {
            try
            {
                using (TextWriter file = File.CreateText(TempFile))
                {
                    file.WriteLine(curDate);
                    file.WriteLine(maxTime);
                }
            }
            catch { }
        }

        /// <summary>
        /// Запись суточного отчёта
        /// </summary>
        public static void SaveReport()
        {
            try
            {
                using (TextWriter file = File.CreateText(reportFile))
                {
                    file.WriteLine("Отчёт системы Gazer за " + curDate);
                    file.WriteLine("");
                    file.WriteLine("Максимальное врема простоя " + maxTime + " минут");
                    string s = "Отчёт за " + curDate + " записан, ";
                    try
                    {
                        Process.Start(reportCommand);
                        s += "внешняя команда выполнена";
                    }
                    catch
                    {
                        s += "но возникла проблемы при выполнении внешней команды";
                    }
                    Log.Write(s);
                }
            }
            catch
            {
                Log.Write("Возникла проблема при записи отчёта");
            }
        }
    }
}
