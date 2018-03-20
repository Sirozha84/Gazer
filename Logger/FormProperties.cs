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
            Properties.Settings.Default.Server = textBoxServer.Text;
            Properties.Settings.Default.Name = textBoxName.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //Application.Exit();
        }
    }
}
