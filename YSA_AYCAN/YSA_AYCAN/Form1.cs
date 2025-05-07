using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace YSA_AYCAN
{
    public partial class Form1 : Form
    {
        private YapaySinirAgi ysa;
        private Button[,] giri�Butonlar�;
        private const int SATIR_SAYISI = 7;
        private const int S�TUN_SAYISI = 5;

        public Form1()
        {
            InitializeComponent();
            Giri�MatrisiniOlu�tur();
        }

        private void Giri�MatrisiniOlu�tur()
        {
            giri�Butonlar� = new Button[SATIR_SAYISI, S�TUN_SAYISI];

            for (int i = 0; i < SATIR_SAYISI; i++)
            {
                for (int j = 0; j < S�TUN_SAYISI; j++)
                {
                    giri�Butonlar�[i, j] = new Button
                    {
                        Width = 30,
                        Height = 30,
                        Top = 20 + i * 35,
                        Left = 20 + j * 35,
                        BackColor = Color.White,
                        Tag = new Point(i, j)
                    };

                    giri�Butonlar�[i, j].Click += Giri�ButonuT�kland�;
                    groupBox1.Controls.Add(giri�Butonlar�[i, j]);
                }
            }
        }

        private void Giri�ButonuT�kland�(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            buton.BackColor = buton.BackColor == Color.White ? Color.Black : Color.White;

            double[] giri�Matrisi = MatrisDonusum.ButonMatrisindenDiziye(giri�Butonlar�);
            MatrisDonusum.MatrisiYazd�r(richTextBox1, giri�Matrisi, SATIR_SAYISI, S�TUN_SAYISI);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SATIR_SAYISI; i++)
            {
                for (int j = 0; j < S�TUN_SAYISI; j++)
                {
                    giri�Butonlar�[i, j].BackColor = Color.White;
                }
            }

            richTextBox1.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            lblSonu�.Text = "Tan�nan Harf: ";
        }

        private void btnTan�mla_Click(object sender, EventArgs e)
        {
            double ��renmeOran� = (double)numericUpDown1.Value;
            ysa = new YapaySinirAgi(SATIR_SAYISI * S�TUN_SAYISI, 10, 5, ��renmeOran�);

            // E�itim verilerini haz�rla (Temiz veriler veya G�r�lt�l� veriler)
            var egitimVerileri = EgitimVerisi.HazirlaVeriler();

            for (int epoch = 0; epoch < 10000; epoch++)
            {
                foreach (var veri in egitimVerileri)
                {
                    ysa.E�it(veri.Giri�ler, veri.Beklenen��kt�lar);
                }
            }

            MessageBox.Show("Yapay sinir a�� e�itimi tamamland�!");
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (ysa == null)
            {
                MessageBox.Show("�nce a�� tan�mlay�p e�itmelisiniz!");
                return;
            }

            double[] giri�Matrisi = MatrisDonusum.ButonMatrisindenDiziye(giri�Butonlar�);
            double[] ��kt�lar = ysa.Hesapla(giri�Matrisi);

            // ��kt�lar� g�ster
            textBox1.Text = ��kt�lar[0].ToString("0.0000");
            textBox2.Text = ��kt�lar[1].ToString("0.0000");
            textBox3.Text = ��kt�lar[2].ToString("0.0000");
            textBox4.Text = ��kt�lar[3].ToString("0.0000");
            textBox5.Text = ��kt�lar[4].ToString("0.0000");

            // En y�ksek ��kt�y� bul
            int maxIndex = 0;
            double maxValue = ��kt�lar[0];
            for (int i = 1; i < ��kt�lar.Length; i++)
            {
                if (��kt�lar[i] > maxValue)
                {
                    maxValue = ��kt�lar[i];
                    maxIndex = i;
                }
            }

            // Sonucu g�ster
            string tan�nanHarf = "";
            switch (maxIndex)
            {
                case 0: tan�nanHarf = "A"; break;
                case 1: tan�nanHarf = "B"; break;
                case 2: tan�nanHarf = "C"; break;
                case 3: tan�nanHarf = "D"; break;
                case 4: tan�nanHarf = "E"; break;
            }

            lblSonu�.Text = $"Tan�nan Harf: {tan�nanHarf} (%{(maxValue * 100).ToString("0.00")})";
        }
    }
}