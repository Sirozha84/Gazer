using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace Logger
{
    public partial class FormMain : Form
    {
        string Key;
        int SymCount;
        int SymCountLast;
        const string TextWait = "Приложите ключ к считывателю";

        public FormMain()
        {
            InitializeComponent();
            labelKey.Text = TextWait;
        }

        private void timerPing_Tick(object sender, EventArgs e)
        {
            SetStatus(Ping());
        }

        bool Ping()
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

        void SetStatus(bool OK)
        {
            labelStatus.Text = "Статус: " + (OK ? "OK" : "Ошибка соединения с сервером");
            labelStatus.ForeColor = (OK ? Color.Black : Color.Tomato);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetStatus(Ping());
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            Key += e.KeyValue.ToString();
            SymCount++;
            if (SymCount > 7)
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
                            writer.Write("Mark");
                            writer.Write(Properties.Settings.Default.Name);
                            writer.Write(Key);
                            //Читаем ответ от сервера
                            string Answer = reader.ReadString();
                            if (Answer == "OK") Message("Спасибо за визит!");
                            if (Answer == "CPNotfound") Error("Контрольная точка не зарегистрирована");
                            if (Answer == "UserNotfound") Error("Ключ не зарегистрирован");
                            if (Answer == "Result")
                            {
                                FormResult form = new FormResult();
                                form.ShowDialog();
                                writer.Write(form.Result);
                            }
                        }
                    }
                }
                catch
                {
                    Error("Ошибка связи");
                }
                KeyReset();
            }
        }

        //Таймер для обнуления ключа, если он был введён не полностью
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (SymCount > 0 && SymCount == SymCountLast) KeyReset();
            SymCountLast = SymCount;
        }

        void KeyReset()
        {
            SymCount = 0;
            Key = "";
        }

        void Message(string msg)
        {
            labelKey.Text = msg;
            labelKey.ForeColor = Color.White;
            timerMessage.Enabled = true;
        }

        void Error(string msg)
        {
            labelKey.Text = msg;
            labelKey.ForeColor = Color.Tomato;
            timerMessage.Enabled = true;
        }

        private void timerMessage_Tick(object sender, EventArgs e)
        {
            labelKey.Text = TextWait;
            labelKey.ForeColor = Color.Black;
            timerMessage.Enabled = false;
        }
    }
}
