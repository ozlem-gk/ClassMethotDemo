using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethotDemo
{
    public class MusteriManager
    {

       
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Ekleniyor" + musteri.Ad +" " + musteri.SoyAd +" "+musteri.Id +" " +musteri.Tc);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Silme işlemi yapılıyor.." + musteri.Ad + " " + musteri.SoyAd);
        }
        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Güncelleme işlemi yapılıyor.." + musteri.Ad + " " + musteri.SoyAd);
        }
        
    }
}
