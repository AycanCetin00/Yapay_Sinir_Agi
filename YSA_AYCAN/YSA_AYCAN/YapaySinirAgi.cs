using System;
using System.Collections.Generic;
using System.Linq;



/*Bu sınıf, tek gizli katmanlı ileri beslemeli bir yapay sinir ağını temsil eder.
 Eğitim için geri yayılım (backpropagation) algoritmasını kullanır.*/


namespace YSA_AYCAN
{
    public class YapaySinirAgi
    {
        private int girişSayısı, gizliKatmanSayısı, çıktıSayısı;
        private double öğrenmeOranı;

        private double[] girişler;
        private double[] gizliKatman;
        private double[] çıktılar;

        private double[,] ağırlıkGirisGizli;
        private double[,] ağırlıkGizliÇıktı;


        //Sinir ağını başlatır ve yapılandırır
        //Gerekli dizileri ve matris yapılarını oluşturur

        public YapaySinirAgi(int girişSayısı, int gizliKatmanSayısı, int çıktıSayısı, double öğrenmeOranı)
        {
            this.girişSayısı = girişSayısı;
            this.gizliKatmanSayısı = gizliKatmanSayısı;
            this.çıktıSayısı = çıktıSayısı;
            this.öğrenmeOranı = öğrenmeOranı;

            girişler = new double[girişSayısı];
            gizliKatman = new double[gizliKatmanSayısı];
            çıktılar = new double[çıktıSayısı];


            // Ağırlık matrisleri oluşturulur (rastgele değerlerle başlatılacak)
            ağırlıkGirisGizli = new double[girişSayısı, gizliKatmanSayısı];
            ağırlıkGizliÇıktı = new double[gizliKatmanSayısı, çıktıSayısı];

            Random rand = new Random();
            for (int i = 0; i < girişSayısı; i++)
                for (int j = 0; j < gizliKatmanSayısı; j++)
                    ağırlıkGirisGizli[i, j] = rand.NextDouble() - 0.5;

            for (int i = 0; i < gizliKatmanSayısı; i++)
                for (int j = 0; j < çıktıSayısı; j++)
                    ağırlıkGizliÇıktı[i, j] = rand.NextDouble() - 0.5;
        }
        // Bu fonksiyon ileri yayılımı yapar: girişten çıkışa doğru hesaplama yapar
        public double[] Hesapla(double[] girişVerisi)
        {
            girişVerisi.CopyTo(girişler, 0);

            // Gizli katman hesaplaması
            for (int i = 0; i < gizliKatmanSayısı; i++)
            {
                gizliKatman[i] = 0;
                for (int j = 0; j < girişSayısı; j++)
                    gizliKatman[i] += girişler[j] * ağırlıkGirisGizli[j, i];
                gizliKatman[i] = Sigmoid(gizliKatman[i]);
            }

            // Çıkış katmanı hesaplaması
            for (int i = 0; i < çıktıSayısı; i++)
            {
                çıktılar[i] = 0;
                for (int j = 0; j < gizliKatmanSayısı; j++)
                    çıktılar[i] += gizliKatman[j] * ağırlıkGizliÇıktı[j, i];
                çıktılar[i] = Sigmoid(çıktılar[i]);
            }

            return çıktılar;
        }
        //İlk olarak Hesapla fonksiyonunu kullanarak ileri besleme yapar
        //öğrenmesini sağlar. Giriş verisi ve doğru (beklenen) sonuç verilir
        public void Eğit(double[] girişVerisi, double[] beklenenÇıktılar)
        {
            double[] gerçekÇıktılar = Hesapla(girişVerisi);

            double[] çıktıHataları = new double[çıktıSayısı];
            for (int i = 0; i < çıktıSayısı; i++)
                çıktıHataları[i] = (beklenenÇıktılar[i] - gerçekÇıktılar[i]) * SigmoidTürevi(gerçekÇıktılar[i]);

            double[] gizliHatalar = new double[gizliKatmanSayısı];
            for (int i = 0; i < gizliKatmanSayısı; i++)
            {
                gizliHatalar[i] = 0;
                for (int j = 0; j < çıktıSayısı; j++)
                    gizliHatalar[i] += çıktıHataları[j] * ağırlıkGizliÇıktı[i, j];
                gizliHatalar[i] *= SigmoidTürevi(gizliKatman[i]);
            }

            for (int i = 0; i < gizliKatmanSayısı; i++)
                for (int j = 0; j < çıktıSayısı; j++)
                    ağırlıkGizliÇıktı[i, j] += öğrenmeOranı * çıktıHataları[j] * gizliKatman[i];

            for (int i = 0; i < girişSayısı; i++)
                for (int j = 0; j < gizliKatmanSayısı; j++)
                    ağırlıkGirisGizli[i, j] += öğrenmeOranı * gizliHatalar[j] * girişler[i];
        }

        // ✔️ Sigmoid aktivasyon fonksiyonu: çıktıyı 0 ile 1 arasına sıkıştırır
        private double Sigmoid(double x) => 1.0 / (1.0 + Math.Exp(-x));
       
        private double SigmoidTürevi(double x) => x * (1 - x);


        // ✔️ Sigmoid türevi: Öğrenme için gereklidir (çıktı * (1 - çıktı))
        public void GeriYayılım(double[] beklenenÇıktılar)
        {
            // Çıkış katmanı hataları
            double[] çıktıHataları = new double[çıktıSayısı];
            for (int i = 0; i < çıktıSayısı; i++)
                çıktıHataları[i] = (beklenenÇıktılar[i] - çıktılar[i]) * Noron.SigmoidTürevi(çıktılar[i]);

            // Gizli katman hataları
            double[] gizliHatalar = new double[gizliKatmanSayısı];
            for (int i = 0; i < gizliKatmanSayısı; i++)
            {
                gizliHatalar[i] = 0;
                for (int j = 0; j < çıktıSayısı; j++)
                    gizliHatalar[i] += çıktıHataları[j] * ağırlıkGizliÇıktı[i, j];
                gizliHatalar[i] *= Noron.SigmoidTürevi(gizliKatman[i]);
            }

            // Ağırlık güncellemeleri
            for (int i = 0; i < gizliKatmanSayısı; i++)
                for (int j = 0; j < çıktıSayısı; j++)
                    ağırlıkGizliÇıktı[i, j] += öğrenmeOranı * çıktıHataları[j] * gizliKatman[i];

            for (int i = 0; i < girişSayısı; i++)
                for (int j = 0; j < gizliKatmanSayısı; j++)
                    ağırlıkGirisGizli[i, j] += öğrenmeOranı * gizliHatalar[j] * girişler[i];
        }
    }

}
