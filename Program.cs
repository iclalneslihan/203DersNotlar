using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   

            // Bilinçsiz Tür Dönüşümü
            // Küçük tür büyük türe otomatik olarak dönüştürülür.

            byte byteSayi = 58;
            int intSayi = byteSayi;

            short shortSayi = 34;
            long longSayi = shortSayi;

            float floatSayi = 29.45f;
            double doubleSayi = floatSayi;

            Console.WriteLine("Sorunsuz Çalıştı.");


        }
    }
}
