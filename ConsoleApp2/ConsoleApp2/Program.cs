using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("S1: ");
            //string stringS1 = Console.ReadLine();
            //int intS1 = Convert.ToInt32 (stringS1);

            //Console.WriteLine("S2: ");
            //string stringS2 = Console.ReadLine();
            //int intS2 = Convert.ToInt32 (stringS2);

            //int toplam = intS1 + intS2;
            //Console.WriteLine($"toplam = {toplam}");


            Console.Write("F= ");
            string sF = Console.ReadLine();
            double dF = Convert.ToDouble(sF);
           

            double dS = (dF - 32) / 1.8;

            dS = Math.Round(dS, 2);
            Console.WriteLine($"{dF} Fahrenayt = {dS} santigrat derecedir.");

            









        }
    }
}
