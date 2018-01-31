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
    public partial class FormKey : Form
    {
        public string Key;
        int s = 0;

        public FormKey()
        {
            InitializeComponent();
        }

        private void buttonCancel_KeyDown(object sender, KeyEventArgs e)
        {
            s++;
            Key += e.KeyValue.ToString();
            if (s > 7)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
