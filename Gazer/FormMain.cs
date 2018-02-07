using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Diagnostics;

namespace Gazer
{
    public partial class FormMain : Form
    {
        List<Record> Log = new List<Record>();

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
            bool ping = Net.Ping();
            SetStatus(ping);
            if (ping) LoadLog();

            //timerPing_Tick(null, null);
            Left = Properties.Settings.Default.Left;
            Top = Properties.Settings.Default.Top;
            Width = Properties.Settings.Default.Width;
            Height = Properties.Settings.Default.Height;
        }

        void SetStatus(bool OK)
        {
            toolStripStatusLabelStatus.Text = "Статус: " + (OK ? "OK" : "Ошибка соединения с сервером");
            пользователиToolStripMenuItem.Enabled = OK;
            контрольныеТочкиToolStripMenuItem.Enabled = OK;
            параметрыХранилищаToolStripMenuItem.Enabled = OK;
            monthCal.Enabled = OK;
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

        private void параметрыХранилищаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDir form = new FormDir();
            form.ShowDialog();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Left = Left;
            Properties.Settings.Default.Top = Top;
            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Height = Height;
            Properties.Settings.Default.Save();
        }

        //Запрос журнала
        void LoadLog()
        {
            string date = monthCal.SelectionStart.ToString("yyyy.MM.dd");
            Log.Clear();
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    client.Connect(Properties.Settings.Default.Server, Properties.Settings.Default.Port);
                    using (NetworkStream stream = client.GetStream())
                    {
                        BinaryWriter writer = new BinaryWriter(stream);
                        BinaryReader reader = new BinaryReader(stream);
                        writer.Write("ReadLog");
                        writer.Write(date);
                        string t, c, n, r, p;
                        do
                        {
                            t = reader.ReadString();
                            if (t == "End") break;
                            c = reader.ReadString();
                            if (c == "End") break;
                            n = reader.ReadString();
                            if (n == "End") break;
                            r = reader.ReadString();
                            if (r == "End") break;
                            p = reader.ReadString();
                            if (p == "End") break;
                            Log.Add(new Record(t, c, n, r, p));
                        } while (true);
                    }
                }
            }
            catch { }
            DrawLog();
        }

        private void monthCal_DateSelected(object sender, DateRangeEventArgs e) { LoadLog(); }

        /// <summary>
        /// Рисование журнала
        /// </summary>
        void DrawLog()
        {
            labelNotImage.Visible = true;
            listViewLog.BeginUpdate();
            listViewLog.Items.Clear();
            foreach (Record rec in Log)
                listViewLog.Items.Add(rec.Item());
            listViewLog.EndUpdate();
        }

        private void listViewLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ok = listViewLog.SelectedIndices.Count > 0;
            if (ok)
            {
                Record rec = Log[listViewLog.SelectedIndices[0]];
                try
                {
                    pictureBox.Image = Image.FromFile(rec.Photo);
                }
                catch
                {
                    ok = false;
                }
            }
            labelNotImage.Visible = !ok;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            Process.Start(Log[listViewLog.SelectedIndices[0]].Photo);
        }
    }
}
