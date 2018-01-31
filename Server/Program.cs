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

        static void Main(string[] args)
        {
            Console.WriteLine("Gazer Sever     Версия 1.0 (26.01.2018)\n");
            //Загрузка списка пользователей из файла
            LoadUsers();

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
                    {
                        Users.Add(new User(reader.ReadString(),
                                           reader.ReadInt32(),
                                           reader.ReadString()));
                    }
                    SaveUsers();
                }
            }
        }

        static void Log(string rec)
        {
            Console.WriteLine(DateTime.Now + ": " + rec);
        }

        /// <summary>
        /// Загрузка списка пользователей из файла
        /// </summary>
        static void LoadUsers()
        {
            try
            {
                using (TextReader file = File.OpenText(UsersFile))
                {
                    string n;
                    int t;
                    string k;
                    //while (s != null)
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
    }
}
