using System;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;

namespace Gazer
{
    public partial class FormPropertiesSystem : Form
    {
        public FormPropertiesSystem()
        {
            InitializeComponent();
        }

        private void FormProperties_Load(object sender, EventArgs e)
        {
            //Загружаем парамеры хранилища с сервера
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    client.Connect(Properties.Settings.Default.Server, Properties.Settings.Default.Port);
                    using (NetworkStream stream = client.GetStream())
                    {
                        BinaryWriter writer = new BinaryWriter(stream);
                        BinaryReader reader = new BinaryReader(stream);
                        writer.Write("ReadProperties");
                        textBoxDir.Text = reader.ReadString();
                        numericUpDownMinutes.Value = Convert.ToDecimal(reader.ReadString());
                        textBoxCommand.Text = reader.ReadString();
                    }
                }
            }
            catch { }
            numericUpDownMinutes_ValueChanged(null, null);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //Загружаем парамеры хранилища на сервер
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    client.Connect(Properties.Settings.Default.Server, Properties.Settings.Default.Port);
                    using (NetworkStream stream = client.GetStream())
                    {
                        BinaryWriter writer = new BinaryWriter(stream);
                        BinaryReader reader = new BinaryReader(stream);
                        writer.Write("WriteProperties");
                        writer.Write(textBoxDir.Text);
                        writer.Write(numericUpDownMinutes.Value.ToString());
                        writer.Write(textBoxCommand.Text);
                    }
                }
            }
            catch { }
            Close();
        }

        private void buttonDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dir = new FolderBrowserDialog();
            dir.SelectedPath = textBoxDir.Text;
            if (dir.ShowDialog() == DialogResult.OK)
                textBoxDir.Text = dir.SelectedPath;
        }

        private void numericUpDownMinutes_ValueChanged(object sender, EventArgs e)
        {
            textBoxCommand.Enabled = numericUpDownMinutes.Value > 0;
            buttonCommand.Enabled = numericUpDownMinutes.Value > 0;
            buttonTest.Enabled = numericUpDownMinutes.Value > 0;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            //Проверка доступности внешней программы
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    client.Connect(Properties.Settings.Default.Server, Properties.Settings.Default.Port);
                    using (NetworkStream stream = client.GetStream())
                    {
                        BinaryWriter writer = new BinaryWriter(stream);
                        BinaryReader reader = new BinaryReader(stream);
                        writer.Write("TestCommand");
                        writer.Write(textBoxCommand.Text);
                        if (reader.ReadString() == "OK")
                            labelStatus.Text = "Проверка прошла успешно.";
                        else
                            labelStatus.Text = "При проверке произошла ошибка.";
                    }
                }
            }
            catch { }
        }

        private void buttonCommand_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                textBoxCommand.Text = dialog.FileName;
        }
    }
}
