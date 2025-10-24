using System;
using Zar_Oyunu;

namespace zarOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tavlaZari TavlaZari1 = new tavlaZari(6);
            tavlaZari TavlaZari2 = new tavlaZari(6);

            int zar1Sonuc = TavlaZari1.ZarAt();
            int zar2Sonuc = TavlaZari2.ZarAt();

            Console.WriteLine("Zar 1: " + zar1Sonuc);
            Console.WriteLine("Zar 2: " + zar2Sonuc);

            if (zar1Sonuc > zar2Sonuc)
            {
                Console.WriteLine("1. zar kazandı!");
            }
            else if (zar1Sonuc < zar2Sonuc)
            {
                Console.WriteLine("2. zar kazandı!");
            }
            else
            {
                Console.WriteLine("Berabere!");
            }

        }
    }
}
