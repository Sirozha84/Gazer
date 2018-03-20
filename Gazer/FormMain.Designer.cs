namespace Gazer
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрольныеТочкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.параметрыСистемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыПодключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthCal = new System.Windows.Forms.MonthCalendar();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelNotImage = new System.Windows.Forms.Label();
            this.checkedListBoxUsers = new System.Windows.Forms.CheckedListBox();
            this.timerPing = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkedListBoxCP = new System.Windows.Forms.CheckedListBox();
            this.checkBoxCP = new System.Windows.Forms.CheckBox();
            this.checkBoxUsers = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.контрольныеТочкиToolStripMenuItem,
            this.toolStripMenuItem2,
            this.параметрыСистемыToolStripMenuItem,
            this.параметрыПодключенияToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // контрольныеТочкиToolStripMenuItem
            // 
            this.контрольныеТочкиToolStripMenuItem.Name = "контрольныеТочкиToolStripMenuItem";
            this.контрольныеТочкиToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.контрольныеТочкиToolStripMenuItem.Text = "Контрольные точки";
            this.контрольныеТочкиToolStripMenuItem.Click += new System.EventHandler(this.контрольныеТочкиToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(214, 6);
            // 
            // параметрыСистемыToolStripMenuItem
            // 
            this.параметрыСистемыToolStripMenuItem.Name = "параметрыСистемыToolStripMenuItem";
            this.параметрыСистемыToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.параметрыСистемыToolStripMenuItem.Text = "Параметры системы";
            this.параметрыСистемыToolStripMenuItem.Click += new System.EventHandler(this.параметрыХранилищаToolStripMenuItem_Click);
            // 
            // параметрыПодключенияToolStripMenuItem
            // 
            this.параметрыПодключенияToolStripMenuItem.Name = "параметрыПодключенияToolStripMenuItem";
            this.параметрыПодключенияToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.параметрыПодключенияToolStripMenuItem.Text = "Параметры подключения";
            this.параметрыПодключенияToolStripMenuItem.Click += new System.EventHandler(this.параметрыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.справкаToolStripMenuItem1.Text = "Справка";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabelStatus.Text = "Статус:";
            // 
            // listViewLog
            // 
            this.listViewLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewLog.FullRowSelect = true;
            this.listViewLog.Location = new System.Drawing.Point(188, 27);
            this.listViewLog.Name = "listViewLog";
            this.listViewLog.Size = new System.Drawing.Size(584, 507);
            this.listViewLog.TabIndex = 3;
            this.listViewLog.UseCompatibleStateImageBehavior = false;
            this.listViewLog.View = System.Windows.Forms.View.Details;
            this.listViewLog.SelectedIndexChanged += new System.EventHandler(this.listViewLog_SelectedIndexChanged);
            this.listViewLog.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewLog_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Время";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Контрольная точка";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Сотрудник";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Отметка в журнале";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Фото";
            this.columnHeader5.Width = 120;
            // 
            // monthCal
            // 
            this.monthCal.Location = new System.Drawing.Point(12, 27);
            this.monthCal.MaxSelectionCount = 1;
            this.monthCal.Name = "monthCal";
            this.monthCal.TabIndex = 5;
            this.monthCal.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCal_DateSelected);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Location = new System.Drawing.Point(12, 396);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(163, 135);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // labelNotImage
            // 
            this.labelNotImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNotImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelNotImage.Location = new System.Drawing.Point(12, 396);
            this.labelNotImage.Name = "labelNotImage";
            this.labelNotImage.Size = new System.Drawing.Size(163, 135);
            this.labelNotImage.TabIndex = 7;
            this.labelNotImage.Text = "Изображение не доступно";
            this.labelNotImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBoxUsers
            // 
            this.checkedListBoxUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBoxUsers.CheckOnClick = true;
            this.checkedListBoxUsers.FormattingEnabled = true;
            this.checkedListBoxUsers.Location = new System.Drawing.Point(0, 24);
            this.checkedListBoxUsers.Name = "checkedListBoxUsers";
            this.checkedListBoxUsers.Size = new System.Drawing.Size(163, 64);
            this.checkedListBoxUsers.TabIndex = 8;
            this.checkedListBoxUsers.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxUsers_SelectedIndexChanged);
            this.checkedListBoxUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxUsers_MouseDoubleClick);
            // 
            // timerPing
            // 
            this.timerPing.Enabled = true;
            this.timerPing.Interval = 5000;
            this.timerPing.Tick += new System.EventHandler(this.timerPing_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 201);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBoxCP);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxCP);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxUsers);
            this.splitContainer1.Panel2.Controls.Add(this.checkedListBoxUsers);
            this.splitContainer1.Size = new System.Drawing.Size(163, 189);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 9;
            // 
            // checkedListBoxCP
            // 
            this.checkedListBoxCP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBoxCP.CheckOnClick = true;
            this.checkedListBoxCP.FormattingEnabled = true;
            this.checkedListBoxCP.Location = new System.Drawing.Point(0, 27);
            this.checkedListBoxCP.Name = "checkedListBoxCP";
            this.checkedListBoxCP.Size = new System.Drawing.Size(163, 64);
            this.checkedListBoxCP.TabIndex = 9;
            this.checkedListBoxCP.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxCP_SelectedIndexChanged);
            this.checkedListBoxCP.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxCP_MouseDoubleClick);
            // 
            // checkBoxCP
            // 
            this.checkBoxCP.AutoSize = true;
            this.checkBoxCP.Checked = true;
            this.checkBoxCP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCP.Location = new System.Drawing.Point(4, 4);
            this.checkBoxCP.Name = "checkBoxCP";
            this.checkBoxCP.Size = new System.Drawing.Size(146, 17);
            this.checkBoxCP.TabIndex = 9;
            this.checkBoxCP.Text = "Все контрольные точки";
            this.checkBoxCP.UseVisualStyleBackColor = true;
            this.checkBoxCP.CheckedChanged += new System.EventHandler(this.checkBoxCP_CheckedChanged);
            // 
            // checkBoxUsers
            // 
            this.checkBoxUsers.AutoSize = true;
            this.checkBoxUsers.Checked = true;
            this.checkBoxUsers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUsers.Location = new System.Drawing.Point(4, 3);
            this.checkBoxUsers.Name = "checkBoxUsers";
            this.checkBoxUsers.Size = new System.Drawing.Size(119, 17);
            this.checkBoxUsers.TabIndex = 10;
            this.checkBoxUsers.Text = "Все пользователи";
            this.checkBoxUsers.UseVisualStyleBackColor = true;
            this.checkBoxUsers.CheckedChanged += new System.EventHandler(this.checkBoxUsers_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.monthCal);
            this.Controls.Add(this.listViewLog);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelNotImage);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.Text = "Gazer Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыПодключенияToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ListView listViewLog;
        private System.Windows.Forms.MonthCalendar monthCal;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelNotImage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckedListBox checkedListBoxUsers;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Timer timerPing;
        private System.Windows.Forms.ToolStripMenuItem контрольныеТочкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem параметрыСистемыToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox checkedListBoxCP;
        private System.Windows.Forms.CheckBox checkBoxCP;
        private System.Windows.Forms.CheckBox checkBoxUsers;
    }
}

