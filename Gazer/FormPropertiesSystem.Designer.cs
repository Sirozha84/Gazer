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
            this.groupBoxReport = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBrowseSendReport = new System.Windows.Forms.Button();
            this.textBoxSendReport = new System.Windows.Forms.TextBox();
            this.buttonTestSendReport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBrowseReport = new System.Windows.Forms.Button();
            this.textBoxReport = new System.Windows.Forms.TextBox();
            this.checkBoxEveryDay = new System.Windows.Forms.CheckBox();
            this.labelStatus1 = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelAhtung = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCommand = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxTimeOut = new System.Windows.Forms.CheckBox();
            this.groupBoxTimeOutTest = new System.Windows.Forms.GroupBox();
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.groupBoxDir.SuspendLayout();
            this.groupBoxReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            this.groupBoxTimeOutTest.SuspendLayout();
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
            this.buttonOK.Location = new System.Drawing.Point(188, 381);
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
            this.buttonCancel.Location = new System.Drawing.Point(269, 381);
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
            // groupBoxReport
            // 
            this.groupBoxReport.Controls.Add(this.label6);
            this.groupBoxReport.Controls.Add(this.buttonBrowseSendReport);
            this.groupBoxReport.Controls.Add(this.textBoxSendReport);
            this.groupBoxReport.Controls.Add(this.buttonTestSendReport);
            this.groupBoxReport.Controls.Add(this.label5);
            this.groupBoxReport.Controls.Add(this.buttonBrowseReport);
            this.groupBoxReport.Controls.Add(this.textBoxReport);
            this.groupBoxReport.Controls.Add(this.labelStatus1);
            this.groupBoxReport.Location = new System.Drawing.Point(12, 86);
            this.groupBoxReport.Name = "groupBoxReport";
            this.groupBoxReport.Size = new System.Drawing.Size(332, 126);
            this.groupBoxReport.TabIndex = 6;
            this.groupBoxReport.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Выполнять следующую команду:";
            // 
            // buttonBrowseSendReport
            // 
            this.buttonBrowseSendReport.Location = new System.Drawing.Point(274, 71);
            this.buttonBrowseSendReport.Name = "buttonBrowseSendReport";
            this.buttonBrowseSendReport.Size = new System.Drawing.Size(52, 20);
            this.buttonBrowseSendReport.TabIndex = 16;
            this.buttonBrowseSendReport.Text = "Обзор";
            this.buttonBrowseSendReport.UseVisualStyleBackColor = true;
            // 
            // textBoxSendReport
            // 
            this.textBoxSendReport.Location = new System.Drawing.Point(6, 71);
            this.textBoxSendReport.Name = "textBoxSendReport";
            this.textBoxSendReport.Size = new System.Drawing.Size(262, 20);
            this.textBoxSendReport.TabIndex = 15;
            // 
            // buttonTestSendReport
            // 
            this.buttonTestSendReport.Location = new System.Drawing.Point(6, 97);
            this.buttonTestSendReport.Name = "buttonTestSendReport";
            this.buttonTestSendReport.Size = new System.Drawing.Size(75, 23);
            this.buttonTestSendReport.TabIndex = 14;
            this.buttonTestSendReport.Text = "Тест";
            this.buttonTestSendReport.UseVisualStyleBackColor = true;
            this.buttonTestSendReport.Click += new System.EventHandler(this.buttonTestSendReport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Записать отчёт в файл:";
            // 
            // buttonBrowseReport
            // 
            this.buttonBrowseReport.Location = new System.Drawing.Point(274, 32);
            this.buttonBrowseReport.Name = "buttonBrowseReport";
            this.buttonBrowseReport.Size = new System.Drawing.Size(52, 20);
            this.buttonBrowseReport.TabIndex = 12;
            this.buttonBrowseReport.Text = "Обзор";
            this.buttonBrowseReport.UseVisualStyleBackColor = true;
            // 
            // textBoxReport
            // 
            this.textBoxReport.Location = new System.Drawing.Point(6, 32);
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.Size = new System.Drawing.Size(262, 20);
            this.textBoxReport.TabIndex = 11;
            // 
            // checkBoxEveryDay
            // 
            this.checkBoxEveryDay.AutoSize = true;
            this.checkBoxEveryDay.Location = new System.Drawing.Point(18, 82);
            this.checkBoxEveryDay.Name = "checkBoxEveryDay";
            this.checkBoxEveryDay.Size = new System.Drawing.Size(121, 17);
            this.checkBoxEveryDay.TabIndex = 10;
            this.checkBoxEveryDay.Text = "Ежедневный отчёт";
            this.checkBoxEveryDay.UseVisualStyleBackColor = true;
            this.checkBoxEveryDay.CheckedChanged += new System.EventHandler(this.checkBoxEveryDay_CheckedChanged);
            // 
            // labelStatus1
            // 
            this.labelStatus1.AutoSize = true;
            this.labelStatus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus1.Location = new System.Drawing.Point(87, 102);
            this.labelStatus1.Name = "labelStatus1";
            this.labelStatus1.Size = new System.Drawing.Size(0, 13);
            this.labelStatus1.TabIndex = 9;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(6, 79);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 8;
            this.buttonTest.Text = "Тест";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelAhtung
            // 
            this.labelAhtung.Location = new System.Drawing.Point(18, 342);
            this.labelAhtung.Name = "labelAhtung";
            this.labelAhtung.Size = new System.Drawing.Size(320, 28);
            this.labelAhtung.TabIndex = 7;
            this.labelAhtung.Text = "Внимание! Указанные файлы и внешние сценарии или приложения должны быть доступно " +
    "с сервера.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "выполнять следующую команду:";
            // 
            // buttonCommand
            // 
            this.buttonCommand.Location = new System.Drawing.Point(274, 53);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(52, 20);
            this.buttonCommand.TabIndex = 5;
            this.buttonCommand.Text = "Обзор";
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(6, 53);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(262, 20);
            this.textBoxCommand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "минут";
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownMinutes.Location = new System.Drawing.Point(217, 14);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericUpDownMinutes.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownMinutes.TabIndex = 1;
            this.numericUpDownMinutes.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Если отметок нет в течение последних";
            // 
            // checkBoxTimeOut
            // 
            this.checkBoxTimeOut.AutoSize = true;
            this.checkBoxTimeOut.Location = new System.Drawing.Point(18, 218);
            this.checkBoxTimeOut.Name = "checkBoxTimeOut";
            this.checkBoxTimeOut.Size = new System.Drawing.Size(120, 17);
            this.checkBoxTimeOut.TabIndex = 18;
            this.checkBoxTimeOut.Text = "Проверка простоя";
            this.checkBoxTimeOut.UseVisualStyleBackColor = true;
            this.checkBoxTimeOut.CheckedChanged += new System.EventHandler(this.checkBoxTimeOut_CheckedChanged);
            // 
            // groupBoxTimeOutTest
            // 
            this.groupBoxTimeOutTest.Controls.Add(this.labelStatus2);
            this.groupBoxTimeOutTest.Controls.Add(this.label1);
            this.groupBoxTimeOutTest.Controls.Add(this.numericUpDownMinutes);
            this.groupBoxTimeOutTest.Controls.Add(this.label2);
            this.groupBoxTimeOutTest.Controls.Add(this.textBoxCommand);
            this.groupBoxTimeOutTest.Controls.Add(this.buttonCommand);
            this.groupBoxTimeOutTest.Controls.Add(this.label3);
            this.groupBoxTimeOutTest.Controls.Add(this.buttonTest);
            this.groupBoxTimeOutTest.Location = new System.Drawing.Point(12, 222);
            this.groupBoxTimeOutTest.Name = "groupBoxTimeOutTest";
            this.groupBoxTimeOutTest.Size = new System.Drawing.Size(332, 109);
            this.groupBoxTimeOutTest.TabIndex = 7;
            this.groupBoxTimeOutTest.TabStop = false;
            // 
            // labelStatus2
            // 
            this.labelStatus2.AutoSize = true;
            this.labelStatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus2.Location = new System.Drawing.Point(87, 84);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(0, 13);
            this.labelStatus2.TabIndex = 10;
            // 
            // FormPropertiesSystem
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(356, 416);
            this.Controls.Add(this.checkBoxTimeOut);
            this.Controls.Add(this.checkBoxEveryDay);
            this.Controls.Add(this.groupBoxTimeOutTest);
            this.Controls.Add(this.groupBoxReport);
            this.Controls.Add(this.groupBoxDir);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelAhtung);
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
            this.groupBoxReport.ResumeLayout(false);
            this.groupBoxReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            this.groupBoxTimeOutTest.ResumeLayout(false);
            this.groupBoxTimeOutTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDir;
        private System.Windows.Forms.GroupBox groupBoxDir;
        private System.Windows.Forms.GroupBox groupBoxReport;
        private System.Windows.Forms.Label labelAhtung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCommand;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelStatus1;
        private System.Windows.Forms.CheckBox checkBoxTimeOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBrowseSendReport;
        private System.Windows.Forms.TextBox textBoxSendReport;
        private System.Windows.Forms.Button buttonTestSendReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBrowseReport;
        private System.Windows.Forms.TextBox textBoxReport;
        private System.Windows.Forms.CheckBox checkBoxEveryDay;
        private System.Windows.Forms.GroupBox groupBoxTimeOutTest;
        private System.Windows.Forms.Label labelStatus2;
    }
}