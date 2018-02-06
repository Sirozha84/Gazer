using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Server
{
    static class Data
    {
        static string UsersFile = "Users.txt";
        public static List<User> Users = new List<User>();
        static string CPFile = "CheckPoints.txt";
        public static List<CheckPoint> CheckPoints = new List<CheckPoint>();
        static string DirFile = "Dir.txt";
        public static string Dir = "";

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
        public static void LoadDir()
        {
            try
            {
                using (TextReader file = File.OpenText(DirFile))
                {
                    string d = file.ReadLine();
                    if (d != null) Dir = d;
                }
            }
            catch { }
        }

        /// <summary>
        /// Сохранение параметров хранилища в файл
        /// </summary>
        public static void SaveDir()
        {
            try
            {
                using (TextWriter file = File.CreateText(DirFile))
                {
                    file.WriteLine(Dir);
                }

            }
            catch { }
        }
    }
}
