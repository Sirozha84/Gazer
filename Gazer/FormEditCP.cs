using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazer
{
    public partial class FormEditCP : Form
    {
        public string Name;
        public string Description;
        public string Camera;
        public string Login;
        public string Password;

        public FormEditCP(bool New, string n, string d, string c, string l, string p)
        {
            InitializeComponent();
            Text = New ? "Создание новой" : "Изменение" + " контрольной точки";
            textBoxName.Text = n;
            textBoxDes.Text = d;
            checkBoxCam.Checked = c != "";
            textBoxCam.Text = c;
            textBoxLogin.Text = l;
            textBoxPassword.Text = p;
            RefreshCam();
        }

        void RefreshCam()
        {
            textBoxCam.Enabled = checkBoxCam.Checked;
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
            Camera = checkBoxCam.Checked ? textBoxCam.Text : "";
            Login = checkBoxCam.Checked ? textBoxLogin.Text : "";
            Password = checkBoxCam.Checked ? textBoxPassword.Text : "";
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
