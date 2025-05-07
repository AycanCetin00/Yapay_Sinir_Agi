using System;
using System.Windows.Forms;
using System.Drawing;
namespace YSA_AYCAN
{
    public static class MatrisDonusum
    {
        // Buton matrisini ikili matrise çevir
        public static double[] ButonMatrisindenDiziye(Button[,] butonlar)// siyah beyaz işlemi burada gerçekleşiyor. 
        {
            int satirSayisi = butonlar.GetLength(0);
            int sutunSayisi = butonlar.GetLength(1);
            double[] dizi = new double[satirSayisi * sutunSayisi];
            int index = 0;

            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    dizi[index++] = butonlar[i, j].BackColor == Color.Black ? 1.0 : 0.0;
                }
            }

            return dizi;
        }

        // RichTextBox'a matrisi yazdır
        public static void MatrisiYazdır(RichTextBox richTextBox, double[] matris, int satirSayisi, int sutunSayisi)
        {
            richTextBox.Clear();
            var builder = new System.Text.StringBuilder();

            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    builder.Append(matris[i * sutunSayisi + j].ToString("0")).Append(" ");
                }
                builder.AppendLine();
            }

            richTextBox.Text = builder.ToString();
        }

    }
}
