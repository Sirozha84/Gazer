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
    public partial class FormUsers : Form
    {
        List<User> Users = new List<User>();

        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            //Загружаем список пользователей с сервера
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    client.Connect(Properties.Settings.Default.Server, Properties.Settings.Default.Port);
                    using (NetworkStream stream = client.GetStream())
                    {
                        BinaryWriter writer = new BinaryWriter(stream);
                        BinaryReader reader = new BinaryReader(stream);
                        writer.Write("ReadUserList");
                        int c = reader.ReadInt32();
                        for (int i = 0; i < c; i++)
                        {
                            Users.Add(new User(reader.ReadString(),
                                               reader.ReadInt32(),
                                               reader.ReadString()));
                        }
                    }
                }
            }
            catch { }
            DrawList();
        }

        void DrawList()
        {
            listViewUsers.BeginUpdate();
            listViewUsers.Items.Clear();
            foreach (User u in Users)
            {
                ListViewItem user = new ListViewItem();
                user.Text = u.Name;
                user.SubItems.Add(Data.Types[u.Type]);
                user.SubItems.Add(u.Key == "" ? "" : "Есть");
                listViewUsers.Items.Add(user);
            }
            listViewUsers.EndUpdate();
            ButtonsRefresh();
        }

        void ButtonsRefresh()
        {
            bool select = listViewUsers.SelectedIndices.Count > 0;
            buttonEdit.Enabled = select;
            buttonDel.Enabled = select;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormEditUser form = new FormEditUser(true, "", 0, "");
            if (form.ShowDialog() == DialogResult.OK)
            {
                Users.Add(new User(form.Name, form.Type, form.Key));
                DrawList();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonsRefresh();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            Users.RemoveAt(listViewUsers.SelectedIndices[0]);
            DrawList();
        }

        private void listViewUsers_DoubleClick(object sender, EventArgs e)
        {
            Edit();
        }

        void Edit()
        {
            User u = Users[listViewUsers.SelectedIndices[0]];
            FormEditUser form = new FormEditUser(false, u.Name, u.Type, u.Key);
            if (form.ShowDialog() == DialogResult.OK)
            {
                u.Name = form.Name;
                u.Type = form.Type;
                u.Key = form.Key;
                DrawList();
            }
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
                        writer.Write("WriteUserList");
                        writer.Write(Users.Count());
                        foreach (User u in Users)
                        {
                            writer.Write(u.Name);
                            writer.Write(u.Type);
                            writer.Write(u.Key);
                        }
                    }
                }
            }
            catch { }

            Close();
        }
    }


}
