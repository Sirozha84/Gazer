using System;
using System.Windows.Forms;

namespace Logger
{
    public partial class FormProperties : Form
    {
        public FormProperties()
        {
            InitializeComponent();
            textBoxServer.Text = Properties.Settings.Default.Server;
            textBoxName.Text = Properties.Settings.Default.Name;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Server != textBoxServer.Text)
                MessageBox.Show("Адрес сервера изменился,\nдля принятия настроек перезапустите клиент.");
            Properties.Settings.Default.Server = textBoxServer.Text;
            Properties.Settings.Default.Name = textBoxName.Text;
            Properties.Settings.Default.Save();
        }
    }
}
