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
            SetStatus(Net.Ping());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timerPing_Tick(null, null);
        }

        void SetStatus(bool OK)
        {
            toolStripStatusLabelStatus.Text = "Статус: " + (OK ? "OK" : "Ошибка соединения с сервером");
            пользователиToolStripMenuItem.Enabled = OK;
            monthCalendar1.Enabled = OK;
            buttonAll.Enabled = OK;
            buttonNone.Enabled = OK;
            checkedListBoxUsers.Enabled = OK;
            listViewLog.Enabled = OK;
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers form = new FormUsers();
            form.ShowDialog();
        }

        private void контрольныеТочкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCP form = new FormCP();
            form.ShowDialog();
        }
    }
}
