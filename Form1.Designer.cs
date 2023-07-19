namespace _2021512001_MTA_SayiYaziCevirme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(198, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 23);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "ÇEVİR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "TEMİZLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1007, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "PROGRAMI KAPAT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(36, 195);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(430, 259);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(729, 195);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(430, 259);
            this.listBox2.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 39);
            this.button4.TabIndex = 1;
            this.button4.Text = "SAYI BELİRLE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "ÇEVİRMEK İSTEDİĞİNİZ SAYI:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(235, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(231, 39);
            this.button5.TabIndex = 2;
            this.button5.Text = "SAYIYI KAYDET";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sayı";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 505);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button4;
        private Label label2;
        private Button button5;
        private Label label3;
    }
}