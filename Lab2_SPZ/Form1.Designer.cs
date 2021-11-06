namespace Lab3_SPZ
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.larger_button = new System.Windows.Forms.Button();
            this.smaller_button = new System.Windows.Forms.Button();
            this.uninstallation_button = new System.Windows.Forms.Button();
            this.installation_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.compare_button = new System.Windows.Forms.Button();
            programs_listBox = new System.Windows.Forms.ListBox();
            users_listBox = new System.Windows.Forms.ListBox();
            toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(83, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПРОГРАММЫ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(453, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "ПОЛЬЗОВАТЕЛИ";
            // 
            // larger_button
            // 
            this.larger_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.larger_button.Location = new System.Drawing.Point(318, 175);
            this.larger_button.Name = "larger_button";
            this.larger_button.Size = new System.Drawing.Size(64, 35);
            this.larger_button.TabIndex = 4;
            this.larger_button.Text = ">";
            this.larger_button.UseVisualStyleBackColor = true;
            this.larger_button.Click += new System.EventHandler(this.larger_button_Click);
            
            // 
            // smaller_button
            // 
            this.smaller_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smaller_button.Location = new System.Drawing.Point(318, 216);
            this.smaller_button.Name = "smaller_button";
            this.smaller_button.Size = new System.Drawing.Size(64, 37);
            this.smaller_button.TabIndex = 5;
            this.smaller_button.Text = "<";
            this.smaller_button.UseVisualStyleBackColor = true;
            this.smaller_button.Click += new System.EventHandler(this.smaller_button_Click);
            
            // 
            // uninstallation_button
            // 
            this.uninstallation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uninstallation_button.Location = new System.Drawing.Point(166, 376);
            this.uninstallation_button.Name = "uninstallation_button";
            this.uninstallation_button.Size = new System.Drawing.Size(146, 33);
            this.uninstallation_button.TabIndex = 6;
            this.uninstallation_button.Text = "ДЕИНСТАЛЯЦИЯ";
            this.uninstallation_button.UseVisualStyleBackColor = true;
            this.uninstallation_button.Click += new System.EventHandler(this.uninstallation_button_Click);
            
            // 
            // installation_button
            // 
            this.installation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.installation_button.Location = new System.Drawing.Point(12, 376);
            this.installation_button.Name = "installation_button";
            this.installation_button.Size = new System.Drawing.Size(148, 33);
            this.installation_button.TabIndex = 7;
            this.installation_button.Text = "ИНСТАЛЯЦИЯ";
            this.installation_button.UseVisualStyleBackColor = true;
            this.installation_button.Click += new System.EventHandler(this.installation_button_Click);
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_button.Location = new System.Drawing.Point(12, 415);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(148, 33);
            this.update_button.TabIndex = 8;
            this.update_button.Text = "ОБНОВИТЬ";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(388, 376);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(148, 33);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "ДОБАВИТЬ";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.Location = new System.Drawing.Point(542, 376);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(146, 33);
            this.delete_button.TabIndex = 10;
            this.delete_button.Text = "УДАЛИТЬ";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // compare_button
            // 
            this.compare_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compare_button.Location = new System.Drawing.Point(542, 415);
            this.compare_button.Name = "compare_button";
            this.compare_button.Size = new System.Drawing.Size(146, 33);
            this.compare_button.TabIndex = 11;
            this.compare_button.Text = "СРАВНИТЬ";
            this.compare_button.UseVisualStyleBackColor = true;
            compare_button.Click += new System.EventHandler(this.compare_button_Click); 
            // 
            // programs_listBox
            // 
           programs_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
           programs_listBox.FormattingEnabled = true;
            programs_listBox.ItemHeight = 20;
            programs_listBox.Location = new System.Drawing.Point(12, 66);
            programs_listBox.Name = "programs_listBox";
            programs_listBox.Size = new System.Drawing.Size(300, 304);
            programs_listBox.TabIndex = 13;
            programs_listBox.DoubleClick += new System.EventHandler(this.programs_listBox_DoubleClick);
            // 
            // users_listBox
            // 
            users_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            users_listBox.FormattingEnabled = true;
            users_listBox.ItemHeight = 20;
            users_listBox.Location = new System.Drawing.Point(388, 66);
            users_listBox.Name = "users_listBox";
            users_listBox.Size = new System.Drawing.Size(300, 304);
            users_listBox.TabIndex = 14;
            users_listBox.DoubleClick += new System.EventHandler(this.users_listBox_DoubleClick);
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.DoubleClickEnabled = true;
            toolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new System.Drawing.Size(131, 17);
            toolStripStatusLabel.Text = "toolStripStatusLabel1";
            toolStripStatusLabel.DoubleClick += new System.EventHandler(this.toolStripStatusLabel_DoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 477);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(700, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 499);
            this.Controls.Add(users_listBox);
            this.Controls.Add(programs_listBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.compare_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.installation_button);
            this.Controls.Add(this.uninstallation_button);
            this.Controls.Add(this.smaller_button);
            this.Controls.Add(this.larger_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button larger_button;
        private System.Windows.Forms.Button smaller_button;
        private System.Windows.Forms.Button uninstallation_button;
        private System.Windows.Forms.Button installation_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button compare_button;
        public static System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public static System.Windows.Forms.ListBox programs_listBox;
        public static System.Windows.Forms.ListBox users_listBox;
    }
}

