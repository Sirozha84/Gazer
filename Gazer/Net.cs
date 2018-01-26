using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace Gazer
{
    static class Net
    {
        const int Port = 8081;

        public static bool Ping()
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    //client.ReceiveTimeout = 5000;
                    client.Connect(Properties.Settings.Default.Server, 8081);
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
