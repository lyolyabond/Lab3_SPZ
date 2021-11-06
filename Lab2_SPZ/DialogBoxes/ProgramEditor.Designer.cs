namespace Lab3_SPZ.DialogBoxes
{
    partial class ProgramEditor
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
            this.programName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OS_textBox = new System.Windows.Forms.TextBox();
            this.manufacturer_textBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.version_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RAM_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CPU_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HDD_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.change_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.version_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDD_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // programName_textBox
            // 
            this.programName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programName_textBox.Location = new System.Drawing.Point(359, 41);
            this.programName_textBox.Name = "programName_textBox";
            this.programName_textBox.ReadOnly = true;
            this.programName_textBox.Size = new System.Drawing.Size(163, 26);
            this.programName_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название приложения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(81, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип ОС:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(81, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Изготовитель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(81, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дата установки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(81, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Версия:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(81, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Необходимая RAM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(81, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Необходимая частота ЦП:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(81, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Занимаемое пространствo HDD:  ";
            // 
            // OS_textBox
            // 
            this.OS_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OS_textBox.Location = new System.Drawing.Point(359, 87);
            this.OS_textBox.Name = "OS_textBox";
            this.OS_textBox.Size = new System.Drawing.Size(163, 26);
            this.OS_textBox.TabIndex = 10;
            // 
            // manufacturer_textBox
            // 
            this.manufacturer_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturer_textBox.Location = new System.Drawing.Point(359, 128);
            this.manufacturer_textBox.Name = "manufacturer_textBox";
            this.manufacturer_textBox.Size = new System.Drawing.Size(163, 26);
            this.manufacturer_textBox.TabIndex = 11;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(340, 165);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 12;
            // 
            // version_numericUpDown
            // 
            this.version_numericUpDown.DecimalPlaces = 2;
            this.version_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.version_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.version_numericUpDown.Location = new System.Drawing.Point(381, 202);
            this.version_numericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.version_numericUpDown.Name = "version_numericUpDown";
            this.version_numericUpDown.Size = new System.Drawing.Size(120, 26);
            this.version_numericUpDown.TabIndex = 13;
            // 
            // RAM_numericUpDown
            // 
            this.RAM_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAM_numericUpDown.Location = new System.Drawing.Point(381, 242);
            this.RAM_numericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.RAM_numericUpDown.Name = "RAM_numericUpDown";
            this.RAM_numericUpDown.Size = new System.Drawing.Size(120, 26);
            this.RAM_numericUpDown.TabIndex = 14;
            // 
            // CPU_numericUpDown
            // 
            this.CPU_numericUpDown.DecimalPlaces = 2;
            this.CPU_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPU_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.CPU_numericUpDown.Location = new System.Drawing.Point(381, 285);
            this.CPU_numericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CPU_numericUpDown.Name = "CPU_numericUpDown";
            this.CPU_numericUpDown.Size = new System.Drawing.Size(120, 26);
            this.CPU_numericUpDown.TabIndex = 15;
            // 
            // HDD_numericUpDown
            // 
            this.HDD_numericUpDown.DecimalPlaces = 2;
            this.HDD_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HDD_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.HDD_numericUpDown.Location = new System.Drawing.Point(381, 327);
            this.HDD_numericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.HDD_numericUpDown.Name = "HDD_numericUpDown";
            this.HDD_numericUpDown.Size = new System.Drawing.Size(120, 26);
            this.HDD_numericUpDown.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(517, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "GB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(517, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "ГГц";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(517, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "GB";
            // 
            // change_button
            // 
            this.change_button.BackColor = System.Drawing.Color.Yellow;
            this.change_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.change_button.Location = new System.Drawing.Point(269, 378);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(109, 54);
            this.change_button.TabIndex = 20;
            this.change_button.Text = "Изменить";
            this.change_button.UseVisualStyleBackColor = false;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // ProgramEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HDD_numericUpDown);
            this.Controls.Add(this.CPU_numericUpDown);
            this.Controls.Add(this.RAM_numericUpDown);
            this.Controls.Add(this.version_numericUpDown);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.manufacturer_textBox);
            this.Controls.Add(this.OS_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.programName_textBox);
            this.Name = "ProgramEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgramEditor";
            this.Load += new System.EventHandler(this.ProgramEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.version_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDD_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox programName_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OS_textBox;
        private System.Windows.Forms.TextBox manufacturer_textBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown version_numericUpDown;
        private System.Windows.Forms.NumericUpDown RAM_numericUpDown;
        private System.Windows.Forms.NumericUpDown CPU_numericUpDown;
        private System.Windows.Forms.NumericUpDown HDD_numericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button change_button;
    }
}