using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesiÖdevi
{
    class Ilanlar
    {
        public int ilanID;
        public string tarih;
        public string baslik;
        public string aciklama;
        public int fiyat;
        public string satilikMikiralikMi;
        public Kullanicilar kullanici;
    }
    public Ilanlar()
    {

    }
    public Ilanlar(int ilanID, string tarih, string baslik, string aciklama,
                     int fiyat, string satilikMikiralikMi, Kullanicilar kullanici);

    { 
       this.ilanID = ilanID;
       this.tarih = tarih;
           this.baslik = baslik;
           this.aciklama = aciklama;
           this.fiyat = fiyat;
           this.satilikMikiralikMi = satilikMikiralikMi;
           this.kullanici = kullanici;
           }
    public void BilgiYaz()
    {
        Console.WriteLine(this.ilanID);
        Console.WriteLine(this.tarih);
        Console.WriteLine(this.baslik);
        Console.WriteLine(this.aciklama);
        Console.WriteLine(this.fiyat);
        Console.WriteLine(this.satilikMikiralikMi);
        Console.WriteLine(this.kullanici.adsoyad);
    }

}
