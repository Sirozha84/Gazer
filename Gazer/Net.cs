using System;
using System.Net.Sockets;
using System.IO;

namespace Gazer
{
    static class Net
    {
        public static bool Ping()
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    //client.ReceiveTimeout = 5000;
                    client.Connect(Properties.Settings.Default.Server, Properties.Settings.Default.Port);
                    using (NetworkStream stream = client.GetStream())
                    {
                        Console.WriteLine(client.Connected);
                        BinaryWriter writer = new BinaryWriter(stream);
                        BinaryReader reader = new BinaryReader(stream);
                        //Посылаем сообщение
                        writer.Write("Ping");
                        //Читаем ответ от сервера
                        return reader.ReadString() == "Pong";
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
