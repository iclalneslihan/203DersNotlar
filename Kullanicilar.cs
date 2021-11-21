using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesiÖdevi
{
    class Kullanicilar
    {
        public int ID;
        public string adsoyad;
        public string adres;
        public string telefon;
        public List<Ilanlar> ilanlar;

        public Kullanicilar()
        {
            this.ilanlar = new List<Ilanlar>();
        }
        public void BilgiYaz()
        {
            Console.WriteLine($"Kullanıcı Adı Soyadı: {this.adsoyad}");
            Console.WriteLine($"Kullanıcı ID: {this.ID}");
        }
        public void kullaniciDuzenleme()
        {
            Console.WriteLine($"*****{this.adsoyad} kullanıcının ilanları ****");
            foreach (var item in this.ilanlar)
            {
                Console.WriteLine(item.ilanID);
            }
            Console.WriteLine("***********************************************************");
        }
    }
}
