using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace Server
{
    class Program
    {
        static string UsersFile = "Users.txt";
        static List<User> Users = new List<User>();
        static string CPFile = "CheckPoints.txt";
        static List<CheckPoint> CheckPoints = new List<CheckPoint>();

        static void Main(string[] args)
        {
            Console.WriteLine("Gazer Sever     Версия 1.0 (26.01.2018)\n");
            
            //Загрузка списка данных из файлов
            LoadUsers();
            LoadCP();

            //Запуск сервера
            TcpListener server = new TcpListener(IPAddress.Any, 8081);
            server.Start();
            Log("Сервер запущен...");
            while (true)
            {
                ThreadPool.QueueUserWorkItem(call, server.AcceptTcpClient());
            }
        }

        //Обработка клиента
        static void call(object clientobject)
        {
            TcpClient client = clientobject as TcpClient;
            using (NetworkStream stream = client.GetStream())
            {
                BinaryReader reader = new BinaryReader(stream);
                BinaryWriter writer = new BinaryWriter(stream);
                
                //Принимаем запрос клиента
                string Request = reader.ReadString();
                
                //Проверка связи
                if (Request == "Ping")
                {
                    writer.Write("Pong");
                }
                //Список пользователей
                if (Request == "ReadUserList")
                {
                    writer.Write(Users.Count);
                    foreach (User user in Users)
                    {
                        writer.Write(user.Name);
                        writer.Write(user.Type);
                        writer.Write(user.Key);
                    }
                }
                if (Request == "WriteUserList")
                {
                    int c = reader.ReadInt32();
                    Users.Clear();
                    for (int i = 0; i < c; i++)
                        Users.Add(new User(reader.ReadString(), reader.ReadInt32(), reader.ReadString()));
                    SaveUsers();
                }
                //Список контрольных точек
                if (Request == "ReadCheckPoints")
                {
                    writer.Write(CheckPoints.Count);
                    foreach (CheckPoint cp in CheckPoints)
                    {
                        writer.Write(cp.Name);
                        writer.Write(cp.Description);
                        writer.Write(cp.Result);
                        writer.Write(cp.Camera);
                        writer.Write(cp.IP);
                        writer.Write(cp.Login);
                        writer.Write(cp.Password);
                    }
                }
                if (Request == "WriteCheckPoints")
                {
                    int c = reader.ReadInt32();
                    CheckPoints.Clear();
                    for (int i = 0; i < c; i++)
                        CheckPoints.Add(new CheckPoint(reader.ReadString(), reader.ReadString(),
                                                       reader.ReadBoolean(), reader.ReadBoolean(),
                                                       reader.ReadString(), reader.ReadString(), reader.ReadString()));
                    SaveCP();
                }
                //Отметка сотрудника
                if (Request == "Mark")
                {
                    //Проверяем кто к нам и откуда ломится
                    string s = reader.ReadString();
                    CheckPoint cp = CheckPoints.Find(o => o.Name == s);
                    s = reader.ReadString();
                    User user = Users.Find(o => o.Key == s);
                    if (cp == null) writer.Write("CPNotfound");
                    else if (user == null) writer.Write("UserNotfound");
                    else
                    {
                        //Пользователь опознан, спрашиваем, если надо, дополнительные сведения
                        if (user.Type == 0)
                        {
                            writer.Write("Result");
                            Console.WriteLine( reader.ReadString());
                        }
                        else
                            writer.Write("OK");
                    }
                }
            }
        }

        static void Log(string rec)
        {
            Console.WriteLine(DateTime.Now + ": " + rec);
        }

        #region FILES
        /// <summary>
        /// Загрузка списка пользователей из файла
        /// </summary>
        static void LoadUsers()
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
        static void SaveUsers()
        {
            try
            {
                using (TextWriter file = File.CreateText(UsersFile))
                {
                    foreach(User u in Users)
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
        static void LoadCP()
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
        static void SaveCP()
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
        #endregion
    }
}
