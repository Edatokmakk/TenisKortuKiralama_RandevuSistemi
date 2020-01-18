namespace TenisKortu
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seans13 = new System.Windows.Forms.Button();
            this.seans10 = new System.Windows.Forms.Button();
            this.seans15 = new System.Windows.Forms.Button();
            this.seans14 = new System.Windows.Forms.Button();
            this.seans11 = new System.Windows.Forms.Button();
            this.seans9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tarihuyg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ad soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "kort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "tarih";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(117, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(327, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(327, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kort 1",
            "Kort 2",
            "Kort 3"});
            this.comboBox1.Location = new System.Drawing.Point(117, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.seans13);
            this.groupBox1.Controls.Add(this.seans10);
            this.groupBox1.Controls.Add(this.seans15);
            this.groupBox1.Controls.Add(this.seans14);
            this.groupBox1.Controls.Add(this.seans11);
            this.groupBox1.Controls.Add(this.seans9);
            this.groupBox1.Location = new System.Drawing.Point(117, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 171);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // seans13
            // 
            this.seans13.BackColor = System.Drawing.Color.Lime;
            this.seans13.Location = new System.Drawing.Point(153, 76);
            this.seans13.Name = "seans13";
            this.seans13.Size = new System.Drawing.Size(75, 23);
            this.seans13.TabIndex = 5;
            this.seans13.Text = "13:00-14:00";
            this.seans13.UseVisualStyleBackColor = false;
            this.seans13.Click += new System.EventHandler(this.seans13_Click);
            // 
            // seans10
            // 
            this.seans10.BackColor = System.Drawing.Color.Lime;
            this.seans10.Location = new System.Drawing.Point(153, 28);
            this.seans10.Name = "seans10";
            this.seans10.Size = new System.Drawing.Size(75, 23);
            this.seans10.TabIndex = 4;
            this.seans10.Text = "10:00-11:00";
            this.seans10.UseVisualStyleBackColor = false;
            this.seans10.Click += new System.EventHandler(this.seans10_Click);
            // 
            // seans15
            // 
            this.seans15.BackColor = System.Drawing.Color.Lime;
            this.seans15.Location = new System.Drawing.Point(153, 121);
            this.seans15.Name = "seans15";
            this.seans15.Size = new System.Drawing.Size(75, 23);
            this.seans15.TabIndex = 3;
            this.seans15.Text = "15:00-16:00";
            this.seans15.UseVisualStyleBackColor = false;
            this.seans15.Click += new System.EventHandler(this.seans15_Click);
            // 
            // seans14
            // 
            this.seans14.BackColor = System.Drawing.Color.Lime;
            this.seans14.Location = new System.Drawing.Point(34, 121);
            this.seans14.Name = "seans14";
            this.seans14.Size = new System.Drawing.Size(75, 23);
            this.seans14.TabIndex = 2;
            this.seans14.Text = "14:00-15:00";
            this.seans14.UseVisualStyleBackColor = false;
            this.seans14.Click += new System.EventHandler(this.seans14_Click);
            // 
            // seans11
            // 
            this.seans11.BackColor = System.Drawing.Color.Lime;
            this.seans11.Location = new System.Drawing.Point(34, 76);
            this.seans11.Name = "seans11";
            this.seans11.Size = new System.Drawing.Size(75, 23);
            this.seans11.TabIndex = 1;
            this.seans11.Text = "11:00-12:00";
            this.seans11.UseVisualStyleBackColor = false;
            this.seans11.Click += new System.EventHandler(this.seans11_Click);
            // 
            // seans9
            // 
            this.seans9.BackColor = System.Drawing.Color.Lime;
            this.seans9.Location = new System.Drawing.Point(34, 28);
            this.seans9.Name = "seans9";
            this.seans9.Size = new System.Drawing.Size(75, 23);
            this.seans9.TabIndex = 0;
            this.seans9.Text = "09:00-10:00";
            this.seans9.UseVisualStyleBackColor = false;
            this.seans9.Click += new System.EventHandler(this.seans9_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tarihuyg
            // 
            this.tarihuyg.Location = new System.Drawing.Point(452, 150);
            this.tarihuyg.Name = "tarihuyg";
            this.tarihuyg.Size = new System.Drawing.Size(75, 23);
            this.tarihuyg.TabIndex = 16;
            this.tarihuyg.Text = "uygula";
            this.tarihuyg.UseVisualStyleBackColor = true;
            this.tarihuyg.Click += new System.EventHandler(this.tarihuyg_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Seanslar";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 121);
            this.listBox1.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(551, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 308);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tarihuyg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button seans13;
        private System.Windows.Forms.Button seans10;
        private System.Windows.Forms.Button seans15;
        private System.Windows.Forms.Button seans14;
        private System.Windows.Forms.Button seans11;
        private System.Windows.Forms.Button seans9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button tarihuyg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}