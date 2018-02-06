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

namespace Gazer
{
    public partial class FormCP : Form
    {
        List<CheckPoint> CheckPoints = new List<CheckPoint>();

        public FormCP()
        {
            InitializeComponent();
        }

        private void FormCP_Load(object sender, EventArgs e)
        {
            //Загружаем список контрольных точек с сервера
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    client.Connect(Properties.Settings.Default.Server, Properties.Settings.Default.Port);
                    using (NetworkStream stream = client.GetStream())
                    {
                        BinaryWriter writer = new BinaryWriter(stream);
                        BinaryReader reader = new BinaryReader(stream);
                        writer.Write("ReadCheckPoints");
                        int c = reader.ReadInt32();
                        for (int i = 0; i < c; i++)
                        {
                            CheckPoints.Add(new CheckPoint(reader.ReadString(), reader.ReadString(),
                                                           reader.ReadBoolean(), reader.ReadBoolean(),
                                                           reader.ReadString(), reader.ReadString(), reader.ReadString()));
                        }
                    }
                }
            }
            catch { }
            DrawList();
        }

        void DrawList()
        {
            listViewCP.BeginUpdate();
            listViewCP.Items.Clear();
            foreach (CheckPoint cp in CheckPoints)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = cp.Name;
                lvi.SubItems.Add(cp.Description);
                lvi.SubItems.Add(cp.Result ? "Включено" : "Нет");
                lvi.SubItems.Add(cp.Camera ? "Включено" : "Нет");
                listViewCP.Items.Add(lvi);
            }
            listViewCP.EndUpdate();
            ButtonsRefresh();
        }

        void ButtonsRefresh()
        {
            bool select = listViewCP.SelectedIndices.Count > 0;
            buttonEdit.Enabled = select;
            buttonDel.Enabled = select;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //Передадим на сервер новый список пользователей
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    client.Connect(Properties.Settings.Default.Server, Properties.Settings.Default.Port);
                    using (NetworkStream stream = client.GetStream())
                    {
                        BinaryWriter writer = new BinaryWriter(stream);
                        BinaryReader reader = new BinaryReader(stream);
                        writer.Write("WriteCheckPoints");
                        writer.Write(CheckPoints.Count());
                        foreach (CheckPoint cp in CheckPoints)
                        {
                            writer.Write(cp.Name);
                            writer.Write(cp.Description);
                            writer.Write(cp.Result);
                            writer.Write(cp.Camera);
                            writer.Write(cp.IP);
                            writer.Write(cp.Login);
                            writer.Write(cp.Password);
                        }
                    }
                }
            }
            catch { }
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormEditCP form = new FormEditCP(true, "", "", false, false, "", "", "");
            if (form.ShowDialog() == DialogResult.OK)
            {
                CheckPoints.Add(new CheckPoint(form.Name, form.Description,
                                               form.Result, form.Camera,
                                               form.IP, form.Login, form.Password));
                DrawList();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e) { Edit(); }
        private void listViewUsers_MouseDoubleClick(object sender, MouseEventArgs e) { Edit(); }
        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e) { ButtonsRefresh(); }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            CheckPoints.RemoveAt(listViewCP.SelectedIndices[0]);
            DrawList(); 
        }

        void Edit()
        {
            CheckPoint cp = CheckPoints[listViewCP.SelectedIndices[0]];
            FormEditCP form = new FormEditCP(false, cp.Name, cp.Description,
                                                    cp.Result, cp.Camera,
                                                    cp.IP, cp.Login, cp.Password);
            if (form.ShowDialog() == DialogResult.OK)
            {
                cp.Name = form.Name;
                cp.Description = form.Description;
                cp.Result = form.Result;
                cp.Camera = form.Camera;
                cp.IP = form.IP;
                cp.Login = form.Login;
                cp.Password = form.Password;
                DrawList();
            }
        }

    }
}
