using System;

namespace EmlakSitesiÖdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.adsoyad = "EnesAslan";
            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.adsoyad = "ElifYılmaz";

            Ilanlar ilan1 = new Ilanlar();
            ilan1.baslik = "kadıköykiralık";
            ilan1.kullanici = kullanici1;

            Ilanlar ilan2 = new Ilanlar();
            ilan2.baslik = "üsküdarkiralık";
            ilan2.kullanici = kullanici1;

            Ilanlar ilan3 = new Ilanlar();
            ilan3.baslik = "maltepesatılık";
            ilan3.kullanici = kullanici2;

            kullanici1.ilanlar.Add(ilan1);
            kullanici1.ilanlar.Add(ilan2);
            kullanici2.ilanlar.Add(ilan3);

            






        }
    }
}
