namespace Gazer
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.tabControlHelp = new System.Windows.Forms.TabControl();
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.richTextBoxHelp = new System.Windows.Forms.RichTextBox();
            this.tabPageHystory = new System.Windows.Forms.TabPage();
            this.richTextBoxHystory = new System.Windows.Forms.RichTextBox();
            this.tabControlHelp.SuspendLayout();
            this.tabPageHelp.SuspendLayout();
            this.tabPageHystory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlHelp
            // 
            this.tabControlHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlHelp.Controls.Add(this.tabPageHelp);
            this.tabControlHelp.Controls.Add(this.tabPageHystory);
            this.tabControlHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlHelp.Location = new System.Drawing.Point(12, 12);
            this.tabControlHelp.Name = "tabControlHelp";
            this.tabControlHelp.SelectedIndex = 0;
            this.tabControlHelp.Size = new System.Drawing.Size(560, 437);
            this.tabControlHelp.TabIndex = 0;
            this.tabControlHelp.TabStop = false;
            // 
            // tabPageHelp
            // 
            this.tabPageHelp.Controls.Add(this.richTextBoxHelp);
            this.tabPageHelp.Location = new System.Drawing.Point(4, 29);
            this.tabPageHelp.Name = "tabPageHelp";
            this.tabPageHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHelp.Size = new System.Drawing.Size(552, 404);
            this.tabPageHelp.TabIndex = 0;
            this.tabPageHelp.Text = "Общие сведения";
            this.tabPageHelp.UseVisualStyleBackColor = true;
            // 
            // richTextBoxHelp
            // 
            this.richTextBoxHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxHelp.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxHelp.Name = "richTextBoxHelp";
            this.richTextBoxHelp.Size = new System.Drawing.Size(546, 398);
            this.richTextBoxHelp.TabIndex = 0;
            this.richTextBoxHelp.Text = resources.GetString("richTextBoxHelp.Text");
            // 
            // tabPageHystory
            // 
            this.tabPageHystory.Controls.Add(this.richTextBoxHystory);
            this.tabPageHystory.Location = new System.Drawing.Point(4, 29);
            this.tabPageHystory.Name = "tabPageHystory";
            this.tabPageHystory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHystory.Size = new System.Drawing.Size(552, 404);
            this.tabPageHystory.TabIndex = 1;
            this.tabPageHystory.Text = "История версий";
            this.tabPageHystory.UseVisualStyleBackColor = true;
            // 
            // richTextBoxHystory
            // 
            this.richTextBoxHystory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxHystory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxHystory.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxHystory.Name = "richTextBoxHystory";
            this.richTextBoxHystory.Size = new System.Drawing.Size(546, 398);
            this.richTextBoxHystory.TabIndex = 1;
            this.richTextBoxHystory.Text = resources.GetString("richTextBoxHystory.Text");
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tabControlHelp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FormHelp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справка";
            this.tabControlHelp.ResumeLayout(false);
            this.tabPageHelp.ResumeLayout(false);
            this.tabPageHystory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlHelp;
        private System.Windows.Forms.TabPage tabPageHelp;
        private System.Windows.Forms.RichTextBox richTextBoxHelp;
        private System.Windows.Forms.TabPage tabPageHystory;
        private System.Windows.Forms.RichTextBox richTextBoxHystory;
    }
}