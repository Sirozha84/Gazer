using System;
using System.Drawing;
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
        UserActivityHook actHook;
        bool lastPing;

        public FormMain()
        {
            InitializeComponent();
            Properties.Settings.Default.Name = Properties.Settings.Default.Name;
            Properties.Settings.Default.Server = Properties.Settings.Default.Server;
            Properties.Settings.Default.Port = Properties.Settings.Default.Port;
            Properties.Settings.Default.Save(); //Потом, после того как будет интерфейс настроек - убрать
            lastPing = Ping();
            textBoxLog.Text = "Вас приветствует система контроля доступа Gazer!" + Environment.NewLine;
            Log("Подключение...", "");
            if (lastPing)
            {
                Log("Сервер доступен, система готова к работе.", "");
                textBoxLog.AppendText("Пожалуйста, поднесите ключ к считывателю." + Environment.NewLine);

            }
            else
            {
                Log("Сервер не доступен, ожидаю подключения...", "");
            }
            //Запускаем хук на отлов клавиатуры
            actHook = new UserActivityHook(); 
            actHook.KeyDown += new KeyEventHandler(MyKeyDown);
        }

        private void timerPing_Tick(object sender, EventArgs e)
        {
            bool ping = Ping();
            SetStatus(ping);
            if (ping != lastPing)
            {
                if (ping) Log("Связь восстановлена", "");
                else Log("Связь потеряна", "");
                lastPing = ping;
            }
            //actHook.Start();
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
            catch { return false; }
        }

        void SetStatus(bool OK)
        {
            labelStatus.Text = "Статус: " + (OK ? "OK   поднесите ключ" : "Ошибка соединения с сервером");
            labelStatus.ForeColor = (OK ? Color.White : Color.Tomato);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetStatus(Ping());
        }

        private void MyKeyDown(object sender, KeyEventArgs e)
        {
            Key += e.KeyValue.ToString();
            SymCount++;
            if (SymCount >= Properties.Settings.Default.KeyBytes)
            {
                actHook.Stop();
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
                            writer.Write("Check");
                            writer.Write(Properties.Settings.Default.Name);
                            writer.Write(Key);
                            //Читаем ответ от сервера
                            string Answer = reader.ReadString();
                            if (Answer == "OK") OKMessage();
                            if (Answer == "CPNotfound") Error("Контрольная точка не зарегистрирована", Properties.Settings.Default.Name);
                            if (Answer == "UserNotfound") Error("Ключ не зарегистрирован", Key);
                            if (Answer == "Result")
                            {
                                FormResult form = new FormResult();
                                form.TopMost = true;
                                form.ShowDialog();
                                writer.Write(form.Result);
                                if (reader.ReadString() == "OK")
                                    OKMessage();
                                form.Dispose(); //На всякий случай
                            }
                        }
                    }
                }
                catch
                {
                    Error("Ошибка связи", "");
                }
                actHook.Start();
            }
        }

        //Таймер для обнуления ключа, если он был введён не полностью
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (SymCount > 0 && SymCount == SymCountLast)
            {
                SymCount = 0;
                Key = "";
            }
            SymCountLast = SymCount;
        }

        /// <summary>
        /// Хорошее сообщение
        /// </summary>
        void OKMessage()
        {
            Log("Удачно", "");
            FormMessage form = new FormMessage("Спасибо за визит!", false);
            form.TopMost = true;
            form.ShowDialog();
        }

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        /// <param name="msg"></param>
        void Error(string msg, string des)
        {
            if (des == "")
                Log(msg, "");
            else
                Log(msg, " (" + des + ")");
            FormMessage form = new FormMessage(msg, true);
            form.TopMost = true;
            form.ShowDialog();
        }

        /// <summary>
        /// Запись лога + вывод на экран
        /// </summary>
        /// <param name="msg"></param>
        void Log(string msg, string des)
        {
            textBoxLog.AppendText(DateTime.Now.ToString("HH:mm ") + msg + Environment.NewLine);
            textBoxLog.SelectionStart = textBoxLog.TextLength;
            textBoxLog.ScrollToCaret();
            try
            {
                StreamWriter file = File.AppendText("Log.txt");
                file.WriteLine(DateTime.Now.ToString("yyyy.MM.dd HH:mm - " + msg + des));
                file.Close();
            }
            catch { }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Закрываем хук при выходе, шоп комп не помер
            actHook.Stop();
        }

        private void timerKeyCheck_Tick(object sender, EventArgs e)
        {
        }
    }
}
