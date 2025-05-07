using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace YSA_AYCAN
{
    public partial class Form1 : Form
    {
        private YapaySinirAgi ysa;
        private Button[,] giriþButonlarý;
        private const int SATIR_SAYISI = 7;
        private const int SÜTUN_SAYISI = 5;

        public Form1()
        {
            InitializeComponent();
            GiriþMatrisiniOluþtur();
        }

        private void GiriþMatrisiniOluþtur()
        {
            giriþButonlarý = new Button[SATIR_SAYISI, SÜTUN_SAYISI];

            for (int i = 0; i < SATIR_SAYISI; i++)
            {
                for (int j = 0; j < SÜTUN_SAYISI; j++)
                {
                    giriþButonlarý[i, j] = new Button
                    {
                        Width = 30,
                        Height = 30,
                        Top = 20 + i * 35,
                        Left = 20 + j * 35,
                        BackColor = Color.White,
                        Tag = new Point(i, j)
                    };

                    giriþButonlarý[i, j].Click += GiriþButonuTýklandý;
                    groupBox1.Controls.Add(giriþButonlarý[i, j]);
                }
            }
        }

        private void GiriþButonuTýklandý(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            buton.BackColor = buton.BackColor == Color.White ? Color.Black : Color.White;

            double[] giriþMatrisi = MatrisDonusum.ButonMatrisindenDiziye(giriþButonlarý);
            MatrisDonusum.MatrisiYazdýr(richTextBox1, giriþMatrisi, SATIR_SAYISI, SÜTUN_SAYISI);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SATIR_SAYISI; i++)
            {
                for (int j = 0; j < SÜTUN_SAYISI; j++)
                {
                    giriþButonlarý[i, j].BackColor = Color.White;
                }
            }

            richTextBox1.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            lblSonuç.Text = "Tanýnan Harf: ";
        }

        private void btnTanýmla_Click(object sender, EventArgs e)
        {
            double öðrenmeOraný = (double)numericUpDown1.Value;
            ysa = new YapaySinirAgi(SATIR_SAYISI * SÜTUN_SAYISI, 10, 5, öðrenmeOraný);

            // Eðitim verilerini hazýrla (Temiz veriler veya Gürültülü veriler)
            var egitimVerileri = EgitimVerisi.HazirlaVeriler();

            for (int epoch = 0; epoch < 10000; epoch++)
            {
                foreach (var veri in egitimVerileri)
                {
                    ysa.Eðit(veri.Giriþler, veri.BeklenenÇýktýlar);
                }
            }

            MessageBox.Show("Yapay sinir aðý eðitimi tamamlandý!");
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (ysa == null)
            {
                MessageBox.Show("Önce aðý tanýmlayýp eðitmelisiniz!");
                return;
            }

            double[] giriþMatrisi = MatrisDonusum.ButonMatrisindenDiziye(giriþButonlarý);
            double[] çýktýlar = ysa.Hesapla(giriþMatrisi);

            // Çýktýlarý göster
            textBox1.Text = çýktýlar[0].ToString("0.0000");
            textBox2.Text = çýktýlar[1].ToString("0.0000");
            textBox3.Text = çýktýlar[2].ToString("0.0000");
            textBox4.Text = çýktýlar[3].ToString("0.0000");
            textBox5.Text = çýktýlar[4].ToString("0.0000");

            // En yüksek çýktýyý bul
            int maxIndex = 0;
            double maxValue = çýktýlar[0];
            for (int i = 1; i < çýktýlar.Length; i++)
            {
                if (çýktýlar[i] > maxValue)
                {
                    maxValue = çýktýlar[i];
                    maxIndex = i;
                }
            }

            // Sonucu göster
            string tanýnanHarf = "";
            switch (maxIndex)
            {
                case 0: tanýnanHarf = "A"; break;
                case 1: tanýnanHarf = "B"; break;
                case 2: tanýnanHarf = "C"; break;
                case 3: tanýnanHarf = "D"; break;
                case 4: tanýnanHarf = "E"; break;
            }

            lblSonuç.Text = $"Tanýnan Harf: {tanýnanHarf} (%{(maxValue * 100).ToString("0.00")})";
        }
    }
}