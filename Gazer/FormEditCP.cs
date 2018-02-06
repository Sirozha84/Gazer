using System;
using System.Windows.Forms;

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
    }
}
