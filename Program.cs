using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace unity101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class (Sınıf) ve objeler

            /* -----------Örnek-----------
            Kek kalıbı --> Kek
            Class --> Obje
            */

            /* State (Durum)
            Araba Örneği
            1. Maksimum hız
            2. Renk
            3. Konum 
            gibi karakteristik özellikler = Field (Alan) // Field'a dışardan erişim verilmemeli. Erişim için property kullanılır.

            --Örn--
            Oyuncu Puanı = 14;
            State = Oyuncu Puanı
            Field --> int OyuncuPuani = 14;
            Field = Değişken
            */

            /* Behaviour (Davranış)
            Araba Örneği
            1. Arabayı kullanmak
            2. Sahneden yok olması (destroy)
            gibi 
            // Erişim metotlarla yapılır. (fonksiyon)
            */

            /* Identity (İsim, Adres)
            Bellekteki adresini belirler.  
            */

            // Metotlar
            /*
             * Kod Blokları
             * Main Metodu
             * <Erişim Belirleyici> <Dönüş Türü> <Metot Adı> (Parametre Listesi)
             * <Access Specifier> <Return Type> <Method Name> (Parameter List)
             * {
             *      Methot Body
             *      Method Body
             * }
             */

            //int cevap = Toplama(3, 5);
            //Console.WriteLine(cevap);

            Console.WriteLine(Toplama(3, 5));
            Console.WriteLine(Cikarma(10, 5));
            Console.WriteLine(Carpma(3, 5));
            Console.WriteLine(Bolme(15f, 5f));
        }

        // Toplama İşlemi
        static int Toplama(int num1, int num2)
        {
            //int result = num1 + num2;
            return num1 + num2;
        }

        // Çıkarma İşlemi
        static int Cikarma(int num1, int num2)
        {
            //int result = num1 + num2;
            return num1 - num2;
        }

        // Çarpma İşlemi
        static int Carpma(int num1, int num2)
        {
            //int result = num1 + num2;
            return num1 * num2;
        }

        // Bölme İşlemi
        static float Bolme(float num1, float num2)
        {
            //int result = num1 + num2;
            return num1 / num2;
        }
    }
}