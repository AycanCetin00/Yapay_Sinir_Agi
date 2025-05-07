using System;
using System.Collections.Generic;

namespace YSA_AYCAN
{
    public class EgitimVerisi
    {
        public static double[][] Veriler { get; private set; }
        public static double[][] Beklenenler { get; private set; }

        static EgitimVerisi()
        {
            HazirlaVeriler();
        }

        public static List<(double[] Girişler, double[] BeklenenÇıktılar)> HazirlaVeriler()
        {
            int[,,] egitim = new int[5, 7, 5] {
                { {0,0,1,0,0},
                  {0,1,0,1,0},
                  {1,0,0,0,1},
                  {1,0,0,0,1},
                  {1,1,1,1,1},
                  {1,0,0,0,1},
                  {1,0,0,0,1} }, // A

                { {1,1,1,1,0},
                  {1,0,0,0,1},
                  {1,0,0,0,1},
                  {1,1,1,1,0},
                  {1,0,0,0,1},
                  {1,0,0,0,1},
                  {1,1,1,1,0} }, // B

                { {0,0,1,1,1},
                  {0,1,0,0,0},
                  {1,0,0,0,0},
                  {1,0,0,0,0},
                  {1,0,0,0,0},
                  {0,1,0,0,0},
                  {0,0,1,1,1} }, // C

                { {1,1,1,0,0},
                  {1,0,0,1,0},
                  {1,0,0,0,1},
                  {1,0,0,0,1},
                  {1,0,0,0,1},
                  {1,0,0,1,0},
                  {1,1,1,0,0} }, // D

                { {1,1,1,1,1},
                  {1,0,0,0,0},
                  {1,0,0,0,0},
                  {1,1,1,1,1},
                  {1,0,0,0,0},
                  {1,0,0,0,0},
                  {1,1,1,1,1} }  // E
            };

            double[,] istenenCikti = new double[5, 5] {
                {1,0,0,0,0}, // A
                {0,1,0,0,0}, // B
                {0,0,1,0,0}, // C
                {0,0,0,1,0}, // D
                {0,0,0,0,1}  // E
            };

            Veriler = new double[5][];
            Beklenenler = new double[5][];
            var sonuc = new List<(double[], double[])>();

            for (int i = 0; i < 5; i++)
            {
                Veriler[i] = new double[35];
                int index = 0;
                for (int satir = 0; satir < 7; satir++)
                    for (int sutun = 0; sutun < 5; sutun++)
                        Veriler[i][index++] = egitim[i, satir, sutun];

                Beklenenler[i] = new double[5];
                for (int j = 0; j < 5; j++)
                    Beklenenler[i][j] = istenenCikti[i, j];

                sonuc.Add((Veriler[i], Beklenenler[i]));
            }

            return sonuc;
        }

       public static List<(double[] Girişler, double[] BeklenenÇıktılar)> GürültülüVeriOluştur()
        {
            var veriler = new List<(double[], double[])>();
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                double[] gürültülüVeri = new double[35];
                for (int j = 0; j < 35; j++)
                {
                    double orijinalDeger = Veriler[i][j];
                    double gürültü = (rnd.NextDouble() * 0.2) - 0.1; // -0.1 ile +0.1 arası
                    gürültülüVeri[j] = Math.Max(0, Math.Min(1, orijinalDeger + gürültü)); // 0-1 arasında kalacak şekilde
                }
                veriler.Add((gürültülüVeri, Beklenenler[i]));
            }
            return veriler;
        }
    }
}