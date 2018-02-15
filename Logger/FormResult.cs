using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger
{
    public partial class FormResult : Form
    {
        public string Result = "Отменено";

        public FormResult()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result = "OK";
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result = "NOK";
            Close();
        }
    }
}
