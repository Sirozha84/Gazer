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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.ProductName + "\nВерсия: " + Application.ProductVersion +
                " (" + Program.Date + ")\nАвтор: Сергей Гордеев\n"+
                "Телефон технической поддержки: +7 (906) 916-08-80",
                "О " + Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProperties form = new FormProperties();
            form.ShowDialog();
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHelp form = new FormHelp();
            form.ShowDialog();
        }

        private void timerPing_Tick(object sender, EventArgs e)
        {
            if (Net.Ping())
            {
                toolStripStatusLabelStatus.Text = "Статус: OK";
            }
            else
            {
                toolStripStatusLabelStatus.Text = "Статус: Ошибка соединения с сервером";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timerPing_Tick(null, null);
        }
    }
}
