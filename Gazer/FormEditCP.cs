using System;
using System.Windows.Forms;

using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Drawing;


namespace Gazer
{
    public partial class FormEditCP : Form
    {
        public string Name;
        public string Description;
        public bool Result;
        public bool Camera;
        public string IP;
        public string Login;
        public string Password;

        public FormEditCP(bool New, string n, string d, bool r, bool c, string ip, string l, string p)
        {
            InitializeComponent();
            Text = New ? "Создание новой" : "Изменение" + " контрольной точки";
            textBoxName.Text = n;
            textBoxDes.Text = d;
            checkBoxResult.Checked = r;
            checkBoxCam.Checked = c;
            textBoxIP.Text = ip;
            textBoxLogin.Text = l;
            textBoxPassword.Text = p;
            RefreshCam();
        }

        void RefreshCam()
        {
            textBoxIP.Enabled = checkBoxCam.Checked;
            textBoxLogin.Enabled = checkBoxCam.Checked;
            textBoxPassword.Enabled = checkBoxCam.Checked;
            buttonTest.Enabled = checkBoxCam.Checked & textBoxIP.Text != "" & textBoxLogin.Text != "" & textBoxPassword.Text != "";
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = textBoxName.Text != "";
        }

        private void checkBoxCam_CheckedChanged(object sender, EventArgs e)
        {
            RefreshCam();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Name = textBoxName.Text;
            Description = textBoxDes.Text;
            Result = checkBoxResult.Checked;
            Camera = checkBoxCam.Checked;
            IP = textBoxIP.Text;
            Login = textBoxLogin.Text;
            Password = textBoxPassword.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBoxIP_TextChanged(object sender, EventArgs e) { RefreshCam(); }
        private void textBoxLogin_TextChanged(object sender, EventArgs e) { RefreshCam(); }
        private void textBoxPassword_TextChanged(object sender, EventArgs e) { RefreshCam(); }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            //Проверка камеры на доступность
            try
            {
                //Запрос
                string URL = "http://" + textBoxIP.Text + "/Streaming/channels/1/picture";
                byte[] buffer = new byte[1000000];
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(URL);
                req.Credentials = new NetworkCredential(textBoxLogin.Text, textBoxPassword.Text);
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                int read, total = 0;
                while ((read = stream.Read(buffer, total, 1000)) != 0) { total += read; }
                Bitmap bmp = (Bitmap)Bitmap.FromStream(new MemoryStream(buffer, 0, total));
                MessageBox.Show("Проверка прошла успешно.", "Проверка камеры",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении снимка.", "Проверка камеры",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
