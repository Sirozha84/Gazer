using System;
using System.Drawing;
using System.Windows.Forms;

namespace Logger
{
    public partial class FormMessage : Form
    {
        public FormMessage(string message, bool error)
        {
            InitializeComponent();
            if (error) labelMessage.ForeColor = Color.Tomato;
            labelMessage.Text = message;
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
