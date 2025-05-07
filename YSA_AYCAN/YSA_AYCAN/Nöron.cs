using System;

namespace YSA_AYCAN
{
    public class Noron
    {
        public double[] Ağırlıklar;
        public double Bias;
        public double Çıkış;
        public double Hata;

        private static Random rnd = new Random();

        public Noron(int girişSayısı)
        {
            Ağırlıklar = new double[girişSayısı]; // Ağırlıklar dizisini, verilen giriş sayısına göre oluşturuyoruz

            for (int i = 0; i < girişSayısı; i++)
                Ağırlıklar[i] = rnd.NextDouble() * 2 - 1; // -1 ile 1 arasında
            Bias = rnd.NextDouble() * 2 - 1;
        }
        // Nöronun çıkışını hesaplayan fonksiyon
        public double Hesapla(double[] girişler)
        {
            double toplam = Bias;
            // Tüm girişleri, ağırlıklarıyla çarpıp toplama ekliyoruz

            for (int i = 0; i < girişler.Length; i++)
                toplam += girişler[i] * Ağırlıklar[i];
            Çıkış = Sigmoid(toplam);
            return Çıkış;
        }

        // Sigmoid fonksiyonu: Çıkışı 0 ile 1 arasında sınırlar (yuvarlatır)
        public static double Sigmoid(double x) => 1.0 / (1.0 + Math.Exp(-x));
        // Sigmoid fonksiyonunun türevi: Öğrenme sırasında kullanılır
        public static double SigmoidTürevi(double x) => x * (1 - x);
    }
}
