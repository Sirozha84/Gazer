using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Drawing;
using System.Diagnostics;

namespace Server
{
    class Program
    {
        static int minutes;
        static Timer timer;

        static void Main(string[] args)
        {
            Console.WriteLine("Gazer Server     Версия 2.0.0 (27.03.2018)\n");
            
            //Загрузка данных из файлов
            Data.LoadUsers();
            Data.LoadCP();
            Data.LoadProperties();
            Data.LoadTemp();
            timer = new Timer(tick, null, 0, 60000);
            //Запуск сервера
            TcpListener server = new TcpListener(IPAddress.Any, 8081);
            server.Start();
            Log.Write("Сервер запущен...");
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
                if (Request == "ReadProperties")
                {
                    writer.Write(Data.photosDir);
                    writer.Write(Data.reportEnable);
                    writer.Write(Data.reportFile);
                    writer.Write(Data.reportCommand);
                    writer.Write(Data.timeOutTestEnable);
                    writer.Write(Data.timeOutMinutes);
                    writer.Write(Data.timeOutCommand);
                }
                if (Request == "WriteProperties")
                {
                    int oldMinutes = Data.timeOutMinutes;
                    Data.photosDir = reader.ReadString();
                    Data.reportEnable = reader.ReadBoolean();
                    Data.reportFile = reader.ReadString();
                    Data.reportCommand = reader.ReadString();
                    Data.timeOutTestEnable = reader.ReadBoolean();
                    Data.timeOutMinutes = reader.ReadInt32();
                    Data.timeOutCommand = reader.ReadString();
                    Data.SaveProperties();
                    if (oldMinutes != Data.timeOutMinutes) minutes = 0;
                }
                //Отметка сотрудника
                if (Request == "Check")
                {
                    //Проверяем кто к нам и откуда ломится
                    string c = reader.ReadString();
                    CheckPoint cp = Data.CheckPoints.Find(o => o.Name == c);
                    string u = reader.ReadString();
                    User user = Data.Users.Find(o => o.Key == u);
                    if (cp == null)
                    {
                        writer.Write("CPNotfound");
                        Log.Write("Контрольная точка не зарегистрирована (" + c + ")" + TimePassed());
                    }
                    else if (user == null)
                    {
                        writer.Write("UserNotfound");
                        Log.Write("Ключ не зарегистрирован (" + u + ")" + TimePassed());
                    }
                    else
                    {
                        //Пользователь опознан, спрашиваем дополнительные сведения
                        //если это контролёр ОТК и если эта контрольная точка оснащена монитором
                        if (user.Type == 0 && cp.Result)
                        {
                            writer.Write("Result");
                            writer.Write("OK");
                            Check(cp, user, reader.ReadString());
                        }
                        else
                        {
                            writer.Write("OK");
                            Check(cp, user, "OK");
                        }
                    }
                }
                //Запрос журнала
                if (Request == "ReadLog")
                {
                    string date = reader.ReadString();
                    try
                    {
                        using (TextReader file = File.OpenText("Logs\\" + date + ".txt"))
                        {
                            string s;
                            do
                            {
                                s = file.ReadLine();
                                writer.Write(s);
                            } while (s != null);
                            writer.Write("End");
                        }
                    }
                    catch { }
                }
                //Тест внешней команды
                if (Request == "TestCommand")
                {
                    try
                    {
                        Process.Start(reader.ReadString());
                        writer.Write("OK");
                    }
                    catch
                    {
                        writer.Write("Error");
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
            DateTime time = DateTime.Now;
            string photo = ""; //Строка с полученным фото
            //Запрашиваем фото с камеры, если это нужно
            if (cp.Camera)
            {
                try
                {
                    //Запрос
                    string URL = "http://" + cp.IP + "/Streaming/channels/1/picture";
                    byte[] buffer = new byte[1000000];
                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(URL);
                    req.Credentials = new NetworkCredential(cp.Login, cp.Password);
                    WebResponse resp = req.GetResponse();
                    Stream stream = resp.GetResponseStream();
                    int read, total = 0;
                    while ((read = stream.Read(buffer, total, 1000)) != 0) { total += read; }
                    Bitmap bmp = (Bitmap)Bitmap.FromStream(new MemoryStream(buffer, 0, total));
                    //Сохранение в файл
                    string dir = Data.photosDir + "\\" + time.ToString("yyyy.MM.dd");
                    Directory.CreateDirectory(dir);
                    photo = dir + "\\" + time.ToString("HHmmss") + ".jpg";
                    bmp.Save(photo);
                }
                catch
                {
                    photo = "Error";
                }
            }
            //Делаем запись в журнале
            Directory.CreateDirectory("Logs");
            string filename = "Logs\\" + time.ToString("yyyy.MM.dd") + ".txt";
            using (StreamWriter file = File.AppendText(filename))
            {
                file.WriteLine(time.ToString("HH:mm"));
                file.WriteLine(cp.Name);
                file.WriteLine(u.Name);
                file.WriteLine(res);
                file.WriteLine(photo);
            }
            Log.Write("[" + cp.Name + "] " + u.Name + ", " + res + ", " + TimePassed());
        }

        static string TimePassed()
        {
            string t = " прошло " + minutes.ToString() + " минут";
            minutes = 0;
            return t;
        }

        /// <summary>
        /// Таймер
        /// </summary>
        /// <param name="o"></param>
        static void tick(object o)
        {
            minutes++;
            //Ежедневный отчёт
            if (Data.reportEnable)
            {
                if (minutes > Data.maxTime) Data.maxTime = minutes;
                string now = DateTime.Now.ToString("yyyy.MM.dd");
                if (Data.curDate != now)
                {
                    Data.SaveReport();
                    Data.curDate = now;
                    Data.maxTime = 0;
                }
                Data.SaveTemp();
            }
            //Проверка на простой
            if (Data.timeOutTestEnable)
            {
                if (minutes >= Data.timeOutMinutes)
                {
                    string s = "Зафиксировано бездействие дольше разрешённого, ";
                    try
                    {
                        Process.Start(Data.timeOutCommand);
                        Log.Write(s + "выполнена внешняя команда");
                    }
                    catch
                    {
                        Log.Write(s + "но произошла ошибка при выполнении внешней команды");
                    }
                    minutes = 0;
                }
            }
        }
    }
}
