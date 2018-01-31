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
    public partial class FormEditUser : Form
    {
        public string Name;
        public int Type;
        public string Key;
        bool New;

        public FormEditUser(bool New, string name, int type, string key)
        {
            InitializeComponent();
            this.New = New;
            Text = New ? "Создание нового пользователя" : "Изменение пользователя";
            textBoxName.Text = name;
            comboBoxTypes.DataSource = Data.Types;
            comboBoxTypes.SelectedIndex = type;
            Key = key;
            KeyButtonRefresh();
        }

        void KeyButtonRefresh()
        {
            labelKeyStatus.Text = Key == "" ? "Нет" : "Есть";
            buttonDel.Enabled = Key != "";
        }

        private void buttonKey_Click(object sender, EventArgs e)
        {
            FormKey form = new FormKey();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Key = form.Key;
                KeyButtonRefresh();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Name = textBoxName.Text;
            Type = comboBoxTypes.SelectedIndex;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = textBoxName.Text != "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Key = "";
            KeyButtonRefresh();
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {

        }
    }
}
