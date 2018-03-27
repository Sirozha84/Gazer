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
                        //Папка для фоток
                        textBoxDir.Text = reader.ReadString();
                        //Ежедневный отчёт
                        checkBoxEveryDay.Checked = reader.ReadBoolean();
                        textBoxReport.Text = reader.ReadString();
                        textBoxSendReport.Text = reader.ReadString();
                        //Проверка простоя
                        checkBoxTimeOut.Checked = reader.ReadBoolean();
                        numericUpDownMinutes.Value = reader.ReadInt32();
                        textBoxCommand.Text = reader.ReadString();
                    }
                }
            }
            catch { }
            checkBoxEveryDay_CheckedChanged(null, null);
            checkBoxTimeOut_CheckedChanged(null, null);
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
                        //Папка для фоток
                        writer.Write(textBoxDir.Text);
                        //Ежедневный отчёт
                        writer.Write(checkBoxEveryDay.Checked);
                        writer.Write(textBoxReport.Text);
                        writer.Write(textBoxSendReport.Text);
                        //Проверка простоя
                        writer.Write(checkBoxTimeOut.Checked);
                        writer.Write(Convert.ToInt32(numericUpDownMinutes.Value));
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

        private void buttonTest_Click(object sender, EventArgs e)
        {
            labelStatus2.Text = CommandTest(textBoxCommand.Text);
        }

        //Проверка доступности внешней программы
        string CommandTest(string command)
        {
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
                        writer.Write(command);
                        if (reader.ReadString() == "OK")
                            return "Проверка прошла успешно";
                        else
                            return "Файл не найден";
                    }
                }
            }
            catch { }
            return "При проверке произошла ошибка";
        }

        void BrowseFile(TextBox tb)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                tb.Text = dialog.FileName;
        }

        private void buttonCommand_Click(object sender, EventArgs e) { BrowseFile(textBoxCommand); }
        private void buttonBrowseReport_Click(object sender, EventArgs e) { BrowseFile(textBoxReport); }
        private void buttonBrowseSendReport_Click(object sender, EventArgs e) { BrowseFile(textBoxSendReport); }

        private void checkBoxTimeOut_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTimeOutTest.Enabled = checkBoxTimeOut.Checked;
        }

        private void checkBoxEveryDay_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxReport.Enabled = checkBoxEveryDay.Checked;
        }

        private void buttonTestSendReport_Click(object sender, EventArgs e)
        {
            labelStatus1.Text = CommandTest(textBoxSendReport.Text);
        }

    }
}
