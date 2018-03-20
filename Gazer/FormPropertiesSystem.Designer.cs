namespace Gazer
{
    partial class FormPropertiesSystem
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
            this.labelServer = new System.Windows.Forms.Label();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDir = new System.Windows.Forms.Button();
            this.groupBoxDir = new System.Windows.Forms.GroupBox();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCommand = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDir.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(6, 20);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(293, 13);
            this.labelServer.TabIndex = 0;
            this.labelServer.Text = "Укажите путь к общему ресурсу для хранения снимков:";
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(6, 37);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(262, 20);
            this.textBoxDir.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(188, 239);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(269, 239);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDir
            // 
            this.buttonDir.Location = new System.Drawing.Point(274, 37);
            this.buttonDir.Name = "buttonDir";
            this.buttonDir.Size = new System.Drawing.Size(52, 20);
            this.buttonDir.TabIndex = 4;
            this.buttonDir.Text = "Обзор";
            this.buttonDir.UseVisualStyleBackColor = true;
            this.buttonDir.Click += new System.EventHandler(this.buttonDir_Click);
            // 
            // groupBoxDir
            // 
            this.groupBoxDir.Controls.Add(this.labelServer);
            this.groupBoxDir.Controls.Add(this.buttonDir);
            this.groupBoxDir.Controls.Add(this.textBoxDir);
            this.groupBoxDir.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDir.Name = "groupBoxDir";
            this.groupBoxDir.Size = new System.Drawing.Size(332, 64);
            this.groupBoxDir.TabIndex = 5;
            this.groupBoxDir.TabStop = false;
            this.groupBoxDir.Text = "Хранилище снимков";
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.labelStatus);
            this.groupBoxControl.Controls.Add(this.buttonTest);
            this.groupBoxControl.Controls.Add(this.label4);
            this.groupBoxControl.Controls.Add(this.label3);
            this.groupBoxControl.Controls.Add(this.buttonCommand);
            this.groupBoxControl.Controls.Add(this.textBoxCommand);
            this.groupBoxControl.Controls.Add(this.label2);
            this.groupBoxControl.Controls.Add(this.numericUpDownMinutes);
            this.groupBoxControl.Controls.Add(this.label1);
            this.groupBoxControl.Location = new System.Drawing.Point(12, 82);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(332, 149);
            this.groupBoxControl.TabIndex = 6;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Контроль работоспособности";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(87, 123);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 9;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(6, 118);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 8;
            this.buttonTest.Text = "Тест";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "0 - если проверка не требуется. Внешнее приложение должно быть доступно на сервер" +
    "е.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "выполнять следующую команду:";
            // 
            // buttonCommand
            // 
            this.buttonCommand.Location = new System.Drawing.Point(274, 64);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(52, 20);
            this.buttonCommand.TabIndex = 5;
            this.buttonCommand.Text = "Обзор";
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(6, 64);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(262, 20);
            this.textBoxCommand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "минут";
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMinutes.Location = new System.Drawing.Point(217, 25);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownMinutes.TabIndex = 1;
            this.numericUpDownMinutes.ValueChanged += new System.EventHandler(this.numericUpDownMinutes_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Если отметок нет в течение последних";
            // 
            // FormPropertiesSystem
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(356, 274);
            this.Controls.Add(this.groupBoxControl);
            this.Controls.Add(this.groupBoxDir);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPropertiesSystem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры системы";
            this.Load += new System.EventHandler(this.FormProperties_Load);
            this.groupBoxDir.ResumeLayout(false);
            this.groupBoxDir.PerformLayout();
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDir;
        private System.Windows.Forms.GroupBox groupBoxDir;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCommand;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelStatus;
    }
}