namespace Lab3_SPZ.DialogBoxes
{
    partial class UserEditor
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
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.change_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.oldpassword_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textBox.Location = new System.Drawing.Point(362, 42);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.ReadOnly = true;
            this.name_textBox.Size = new System.Drawing.Size(163, 29);
            this.name_textBox.TabIndex = 0;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_textBox.Location = new System.Drawing.Point(362, 140);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(163, 31);
            this.password_textBox.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(3, 42);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(174, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Имя пользователя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите новый пароль:";
            // 
            // change_button
            // 
            this.change_button.BackColor = System.Drawing.Color.Yellow;
            this.change_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.change_button.Location = new System.Drawing.Point(203, 196);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(109, 54);
            this.change_button.TabIndex = 4;
            this.change_button.Text = "Изменить";
            this.change_button.UseVisualStyleBackColor = false;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите старый пароль:";
            // 
            // oldpassword_textBox
            // 
            this.oldpassword_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldpassword_textBox.Location = new System.Drawing.Point(362, 88);
            this.oldpassword_textBox.Name = "oldpassword_textBox";
            this.oldpassword_textBox.Size = new System.Drawing.Size(163, 31);
            this.oldpassword_textBox.TabIndex = 5;
            // 
            // UserEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(541, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldpassword_textBox);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.name_textBox);
            this.Name = "UserEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserEditor";
            this.Load += new System.EventHandler(this.UserEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldpassword_textBox;
    }
}