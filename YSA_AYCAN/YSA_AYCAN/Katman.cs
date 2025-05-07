namespace YSA_AYCAN
{
    public class Katman
    {
        public Noron[] Noronlar;
        // Katman oluşturulurken kaç nöron olacak ve her biri kaç giriş alacak bilgisi veriliyor
        public Katman(int noronSayısı, int girişSayısı)
        {
            Noronlar = new Noron[noronSayısı];
            for (int i = 0; i < noronSayısı; i++)
                Noronlar[i] = new Noron(girişSayısı); // Her nöron kendi ağırlık ve bias değerlerini alır
        }

        // GeriYayılım fonksiyonu: Öğrenme sırasında hataları hesaplar
         public void GeriYayılım(double[] hatalar, double öğrenmeOranı)
          {
              for (int i = 0; i < Noronlar.Length; i++)
                  Noronlar[i].Hata = hatalar[i] * Noron.SigmoidTürevi(Noronlar[i].Çıkış);
              // Bu hata değeri, öğrenme sırasında ağırlıkları güncellemek için kullanılır

          }

          // İleriYayılım fonksiyonu: Girişleri alıp nöronlardan çıkış üretir
          public double[] İleriYayılım(double[] girişler)
          {

              double[] çıktılar = new double[Noronlar.Length];
              for (int i = 0; i < Noronlar.Length; i++)
                  çıktılar[i] = Noronlar[i].Hesapla(girişler);
              return çıktılar;
          }


    }
}
