namespace Gb
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(15, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1213, 153);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Москва";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(448, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "конвертация в координаты";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 315);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(1213, 153);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Город";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Объект поиска";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(258, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "банкомат";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(15, 542);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox5.Size = new System.Drawing.Size(1213, 153);
            this.textBox5.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 701);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 57);
            this.button2.TabIndex = 15;
            this.button2.Text = "вычислить районы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "получить адреса  с 2ГИС";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 32);
            this.button4.TabIndex = 17;
            this.button4.Text = "удалить адреса";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 474);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 32);
            this.button5.TabIndex = 18;
            this.button5.Text = "удалить координаты";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 200;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(428, 701);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 57);
            this.button6.TabIndex = 19;
            this.button6.Text = "распределить поинты";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(17, 701);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(175, 57);
            this.button7.TabIndex = 20;
            this.button7.Text = "удалить районы";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Районы и их приоритеты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Координаты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Адреса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(578, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "вес";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(497, 37);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(201, 22);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = "9";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(910, 701);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(320, 57);
            this.button8.TabIndex = 23;
            this.button8.Text = "суммировать поинты всех критериев";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(769, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "индекс критерия";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(728, 37);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(201, 22);
            this.textBox7.TabIndex = 24;
            this.textBox7.Text = "1";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 770);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
    }
}

