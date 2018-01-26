using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gazer Sever     Версия 1.0 (26.01.2018)");
            TcpListener server = new TcpListener(IPAddress.Any, 8081);
            server.Start();
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
                    Console.WriteLine("Test OK");
                }
            }
        }
    }
}
