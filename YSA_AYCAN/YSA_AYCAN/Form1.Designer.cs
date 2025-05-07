namespace YSA_AYCAN
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
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox3 = new GroupBox();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            btnTanımla = new Button();
            btnHesapla = new Button();
            btnTemizle = new Button();
            lblSonuç = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 192);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 398);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown1.Location = new Point(174, 300);
            numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(69, 34);
            numericUpDown1.TabIndex = 36;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(68, 300);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 35;
            label1.Text = "Hata Oranı:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 192);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(437, 82);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 398);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Matris Gösterimi ";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(39, 35);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(203, 315);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 192, 192);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(737, 82);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(431, 200);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sonuç";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(47, 161);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(369, 31);
            textBox5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(16, 163);
            label6.Name = "label6";
            label6.Size = new Size(22, 25);
            label6.TabIndex = 8;
            label6.Text = "E";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(47, 127);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(369, 31);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(16, 126);
            label5.Name = "label5";
            label5.Size = new Size(25, 25);
            label5.TabIndex = 6;
            label5.Text = "D";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(47, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(369, 31);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(16, 93);
            label4.Name = "label4";
            label4.Size = new Size(23, 25);
            label4.TabIndex = 4;
            label4.Text = "C";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(47, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(369, 31);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(16, 60);
            label3.Name = "label3";
            label3.Size = new Size(24, 25);
            label3.TabIndex = 2;
            label3.Text = "B";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(16, 26);
            label2.Name = "label2";
            label2.Size = new Size(25, 25);
            label2.TabIndex = 0;
            label2.Text = "A";
            // 
            // btnTanımla
            // 
            btnTanımla.BackColor = Color.FromArgb(255, 128, 128);
            btnTanımla.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTanımla.Location = new Point(737, 298);
            btnTanımla.Name = "btnTanımla";
            btnTanımla.Size = new Size(431, 49);
            btnTanımla.TabIndex = 3;
            btnTanımla.Text = "Tanımla";
            btnTanımla.UseVisualStyleBackColor = false;
            btnTanımla.Click += btnTanımla_Click;
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.FromArgb(255, 128, 128);
            btnHesapla.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnHesapla.Location = new Point(737, 356);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(431, 49);
            btnHesapla.TabIndex = 4;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(255, 128, 128);
            btnTemizle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTemizle.Location = new Point(737, 412);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(431, 49);
            btnTemizle.TabIndex = 5;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // lblSonuç
            // 
            lblSonuç.AutoSize = true;
            lblSonuç.Location = new Point(304, 25);
            lblSonuç.Name = "lblSonuç";
            lblSonuç.Size = new Size(50, 20);
            lblSonuç.TabIndex = 6;
            lblSonuç.Text = "label7";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1199, 508);
            Controls.Add(lblSonuç);
            Controls.Add(btnTemizle);
            Controls.Add(btnHesapla);
            Controls.Add(btnTanımla);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
          //  Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private GroupBox groupBox2;
        private RichTextBox richTextBox1;
        private GroupBox groupBox3;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Button btnTanımla;
        private Button btnHesapla;
        private Button btnTemizle;
        private TextBox textBox5;
        private Label label6;
        private Label lblSonuç;
    }
}
