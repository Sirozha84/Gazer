using System;
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

        private void FormKey_KeyDown(object sender, KeyEventArgs e)
        {
            s++;
            Key += e.KeyValue.ToString();
            if (s >= Properties.Settings.Default.KeyBytes)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            //label1.Text = s.ToString();
        }
    }
}
