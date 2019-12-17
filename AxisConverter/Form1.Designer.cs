namespace Converter {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.YMinBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.YMaxBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.XMinBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.XMaxBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.rbPC = new System.Windows.Forms.RadioButton();
            this.rbDecart = new System.Windows.Forms.RadioButton();
            this.OutputXBox = new System.Windows.Forms.TextBox();
            this.InputXBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InputYBox = new System.Windows.Forms.TextBox();
            this.OutputYBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.YMinBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.YMaxBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.XMinBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.XMaxBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.HeightBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.WidthBox);
            this.groupBox1.Controls.Add(this.rbPC);
            this.groupBox1.Controls.Add(this.rbDecart);
            this.groupBox1.Location = new System.Drawing.Point(30, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные данные";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "YMin:";
            // 
            // YMinBox
            // 
            this.YMinBox.Location = new System.Drawing.Point(54, 170);
            this.YMinBox.Name = "YMinBox";
            this.YMinBox.Size = new System.Drawing.Size(100, 20);
            this.YMinBox.TabIndex = 12;
            this.YMinBox.TextChanged += new System.EventHandler(this.Settings_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "YMax:";
            // 
            // YMaxBox
            // 
            this.YMaxBox.Location = new System.Drawing.Point(54, 195);
            this.YMaxBox.Name = "YMaxBox";
            this.YMaxBox.Size = new System.Drawing.Size(100, 20);
            this.YMaxBox.TabIndex = 10;
            this.YMaxBox.TextChanged += new System.EventHandler(this.Settings_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "XMin:";
            // 
            // XMinBox
            // 
            this.XMinBox.Location = new System.Drawing.Point(54, 118);
            this.XMinBox.Name = "XMinBox";
            this.XMinBox.Size = new System.Drawing.Size(100, 20);
            this.XMinBox.TabIndex = 8;
            this.XMinBox.TextChanged += new System.EventHandler(this.Settings_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "XMax:";
            // 
            // XMaxBox
            // 
            this.XMaxBox.Location = new System.Drawing.Point(54, 144);
            this.XMaxBox.Name = "XMaxBox";
            this.XMaxBox.Size = new System.Drawing.Size(100, 20);
            this.XMaxBox.TabIndex = 6;
            this.XMaxBox.TextChanged += new System.EventHandler(this.Settings_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Height:";
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(54, 93);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(100, 20);
            this.HeightBox.TabIndex = 4;
            this.HeightBox.TextChanged += new System.EventHandler(this.Settings_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Width:";
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(54, 67);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(100, 20);
            this.WidthBox.TabIndex = 2;
            this.WidthBox.TextChanged += new System.EventHandler(this.Settings_TextChanged);
            // 
            // rbPC
            // 
            this.rbPC.AutoSize = true;
            this.rbPC.Location = new System.Drawing.Point(13, 43);
            this.rbPC.Name = "rbPC";
            this.rbPC.Size = new System.Drawing.Size(153, 17);
            this.rbPC.TabIndex = 1;
            this.rbPC.TabStop = true;
            this.rbPC.Text = "Координаты компьютера";
            this.rbPC.UseVisualStyleBackColor = true;
            this.rbPC.CheckedChanged += new System.EventHandler(this.Settings_TextChanged);
            // 
            // rbDecart
            // 
            this.rbDecart.AutoSize = true;
            this.rbDecart.Location = new System.Drawing.Point(13, 19);
            this.rbDecart.Name = "rbDecart";
            this.rbDecart.Size = new System.Drawing.Size(147, 17);
            this.rbDecart.TabIndex = 0;
            this.rbDecart.TabStop = true;
            this.rbDecart.Text = "Декартовы координаты";
            this.rbDecart.UseVisualStyleBackColor = true;
            this.rbDecart.CheckedChanged += new System.EventHandler(this.Settings_TextChanged);
            // 
            // OutputXBox
            // 
            this.OutputXBox.Location = new System.Drawing.Point(132, 31);
            this.OutputXBox.Name = "OutputXBox";
            this.OutputXBox.ReadOnly = true;
            this.OutputXBox.Size = new System.Drawing.Size(68, 20);
            this.OutputXBox.TabIndex = 2;
            // 
            // InputXBox
            // 
            this.InputXBox.Location = new System.Drawing.Point(31, 31);
            this.InputXBox.Name = "InputXBox";
            this.InputXBox.Size = new System.Drawing.Size(75, 20);
            this.InputXBox.TabIndex = 3;
            this.InputXBox.TextChanged += new System.EventHandler(this.InputXBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-16, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y:";
            // 
            // InputYBox
            // 
            this.InputYBox.Location = new System.Drawing.Point(31, 57);
            this.InputYBox.Name = "InputYBox";
            this.InputYBox.Size = new System.Drawing.Size(75, 20);
            this.InputYBox.TabIndex = 7;
            this.InputYBox.TextChanged += new System.EventHandler(this.InputYBox_TextChanged);
            // 
            // OutputYBox
            // 
            this.OutputYBox.Location = new System.Drawing.Point(132, 57);
            this.OutputYBox.Name = "OutputYBox";
            this.OutputYBox.ReadOnly = true;
            this.OutputYBox.Size = new System.Drawing.Size(68, 20);
            this.OutputYBox.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.InputXBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.OutputXBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.InputYBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.OutputYBox);
            this.groupBox2.Location = new System.Drawing.Point(30, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Преобразование";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Y:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "X:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 392);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPC;
        private System.Windows.Forms.RadioButton rbDecart;
        private System.Windows.Forms.TextBox OutputXBox;
        private System.Windows.Forms.TextBox InputXBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InputYBox;
        private System.Windows.Forms.TextBox OutputYBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox YMinBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox YMaxBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox XMinBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox XMaxBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

