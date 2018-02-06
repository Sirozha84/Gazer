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
        static void Main(string[] args)
        {
            Console.WriteLine("Gazer Server     Версия 1.0 (26.01.2018)\n");
            
            //Загрузка списка данных из файлов
            Data.LoadUsers();
            Data.LoadCP();
            Data.LoadDir();

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
                    writer.Write(Data.Users.Count);
                    foreach (User user in Data.Users)
                    {
                        writer.Write(user.Name);
                        writer.Write(user.Type);
                        writer.Write(user.Key);
                    }
                }
                if (Request == "WriteUserList")
                {
                    int c = reader.ReadInt32();
                    Data.Users.Clear();
                    for (int i = 0; i < c; i++)
                        Data.Users.Add(new User(reader.ReadString(), reader.ReadInt32(), reader.ReadString()));
                    Data.SaveUsers();
                }
                //Список контрольных точек
                if (Request == "ReadCheckPoints")
                {
                    writer.Write(Data.CheckPoints.Count);
                    foreach (CheckPoint cp in Data.CheckPoints)
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
                    Data.CheckPoints.Clear();
                    for (int i = 0; i < c; i++)
                        Data.CheckPoints.Add(new CheckPoint(reader.ReadString(), reader.ReadString(),
                                                       reader.ReadBoolean(), reader.ReadBoolean(),
                                                       reader.ReadString(), reader.ReadString(), reader.ReadString()));
                    Data.SaveCP();
                }
                if (Request == "ReadDir")
                {
                    writer.Write(Data.Dir);
                }
                if (Request == "WriteDir")
                {
                    Data.Dir = reader.ReadString();
                    Data.SaveDir();
                }
                //Отметка сотрудника
                if (Request == "Mark")
                {
                    //Проверяем кто к нам и откуда ломится
                    string s = reader.ReadString();
                    CheckPoint cp = Data.CheckPoints.Find(o => o.Name == s);
                    s = reader.ReadString();
                    User user = Data.Users.Find(o => o.Key == s);
                    if (cp == null) writer.Write("CPNotfound");
                    else if (user == null) writer.Write("UserNotfound");
                    else
                    {
                        //Пользователь опознан, спрашиваем, если надо, дополнительные сведения
                        if (user.Type == 0)
                        {
                            writer.Write("Result");
                            Check(cp, user, reader.ReadString());
                            writer.Write("OK");
                        }
                        else
                        {
                            Check(cp, user, "OK");
                            writer.Write("OK");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Регистрация отметки пользователя
        /// </summary>
        /// <param name="cp">Чекпоинт</param>
        /// <param name="u">Пользователь</param>
        /// <param name="res">Результат проверки</param>
        static void Check(CheckPoint cp, User u, string res)
        {
            string photo = ""; //Строка с полученным фото
            //Directory.CreateDirectory(dir);

            Directory.CreateDirectory("Logs");
            string filename = "Logs\\" + DateTime.Now.ToString("yyyy.MM.dd") + ".txt";
            using (StreamWriter file = File.AppendText(filename))
            {
                file.WriteLine(cp.Name);
                file.WriteLine(u.Name);
                file.WriteLine(res);
                file.WriteLine(photo);
            }
            Log(cp.Name + " " + u.Name + " " + res);

        }

        /// <summary>
        /// Запись лога программы
        /// </summary>
        /// <param name="rec">Запись</param>
        static void Log(string rec)
        {
            rec = DateTime.Now.ToString("[yyyy.MM.dd HH:mm] ") + rec;
            Console.WriteLine(rec);
            using (StreamWriter file = File.AppendText("Log.txt"))
                file.WriteLine(rec);
        }

        
    }
}
