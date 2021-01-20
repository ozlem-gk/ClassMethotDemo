using System;

namespace ClassMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Murat";
            musteri1.SoyAd = "Can";
            musteri1.Id = "1";
            musteri1.Tc = "22333444";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Selin";
            musteri2.SoyAd = "Derin";
            musteri2.Id = "2";
            musteri2.Tc = "22333465";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Semih";
            musteri3.SoyAd = "Kuzu";
            musteri3.Id = "3";
            musteri3.Tc = "22333433";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("-------------------------------------");

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);

            Console.WriteLine("-------------------------------------");

            musteriManager.Guncelle(musteri1);
            musteriManager.Guncelle(musteri2);
            musteriManager.Guncelle(musteri3);




        }
    }
}
