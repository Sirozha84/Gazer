namespace Gazer
{
    partial class FormEditCP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.labelDes = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.checkBoxCam = new System.Windows.Forms.CheckBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.labelCam = new System.Windows.Forms.Label();
            this.checkBoxResult = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(322, 251);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(241, 251);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(125, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(217, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(59, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Название:";
            // 
            // textBoxDes
            // 
            this.textBoxDes.Location = new System.Drawing.Point(125, 61);
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(217, 20);
            this.textBoxDes.TabIndex = 1;
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Location = new System.Drawing.Point(59, 64);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(60, 13);
            this.labelDes.TabIndex = 11;
            this.labelDes.Text = "Описание:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(71, 201);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(48, 13);
            this.labelPassword.TabIndex = 15;
            this.labelPassword.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(125, 198);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(217, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(125, 172);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(217, 20);
            this.textBoxLogin.TabIndex = 5;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(78, 175);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(41, 13);
            this.labelLogin.TabIndex = 12;
            this.labelLogin.Text = "Логин:";
            // 
            // checkBoxCam
            // 
            this.checkBoxCam.AutoSize = true;
            this.checkBoxCam.Location = new System.Drawing.Point(125, 123);
            this.checkBoxCam.Name = "checkBoxCam";
            this.checkBoxCam.Size = new System.Drawing.Size(157, 17);
            this.checkBoxCam.TabIndex = 3;
            this.checkBoxCam.Text = "Делать снимок с камеры";
            this.checkBoxCam.UseVisualStyleBackColor = true;
            this.checkBoxCam.CheckedChanged += new System.EventHandler(this.checkBoxCam_CheckedChanged);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(125, 146);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(217, 20);
            this.textBoxIP.TabIndex = 4;
            // 
            // labelCam
            // 
            this.labelCam.AutoSize = true;
            this.labelCam.Location = new System.Drawing.Point(23, 149);
            this.labelCam.Name = "labelCam";
            this.labelCam.Size = new System.Drawing.Size(96, 13);
            this.labelCam.TabIndex = 17;
            this.labelCam.Text = "IP-адрес камеры:";
            // 
            // checkBoxResult
            // 
            this.checkBoxResult.AutoSize = true;
            this.checkBoxResult.Location = new System.Drawing.Point(125, 87);
            this.checkBoxResult.Name = "checkBoxResult";
            this.checkBoxResult.Size = new System.Drawing.Size(243, 30);
            this.checkBoxResult.TabIndex = 2;
            this.checkBoxResult.Text = "Запрашивать результат проверки\r\n(Контрольная точка оснащена монитором)";
            this.checkBoxResult.UseVisualStyleBackColor = true;
            // 
            // FormEditCP
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(409, 286);
            this.Controls.Add(this.checkBoxResult);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.labelCam);
            this.Controls.Add(this.checkBoxCam);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelDes);
            this.Controls.Add(this.textBoxDes);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditCP";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxDes;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.CheckBox checkBoxCam;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label labelCam;
        private System.Windows.Forms.CheckBox checkBoxResult;
    }
}