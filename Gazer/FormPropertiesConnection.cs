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
    public partial class FormPropertiesConnection : Form
    {
        public FormPropertiesConnection()
        {
            InitializeComponent();
        }

        private void FormProperties_Load(object sender, EventArgs e)
        {
            textBoxServer.Text = Properties.Settings.Default.Server;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = textBoxServer.Text;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
