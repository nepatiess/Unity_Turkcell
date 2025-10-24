using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unity101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Konsol nedir, 
            grafiksel olmayan bir kullanıcı arayüzü ile,
            kullanıcıdan bilgi almak ya da vermek için 
            kullanılan siyah bir ekrandır.
            */

            Console.WriteLine("Merhaba, Unity :)");

            // ------------EGZERSİZ 1------------
            // Visual Studio’da yeni bir konsol uygulaması oluşturup ekrana “C# ile programlama öğreniyorum” mesajını yazınız.
            Console.WriteLine("C# ile programlama öğreniyorum");

            /* 
            Veri Türleri (data types)
            1. Tam sayı (integer)
            2. Yazı (string)
            3. Float (1,5)
            4. Double (1,52548)

            Değişkenler (variables)

            Sabitler (constant)
            
            */

            // integer türünde değişken tanımlama
            int oyuncuPuani = 14;
            Console.WriteLine(oyuncuPuani);

            // string türünde değişken tanımlama
            string oyuncuAdi = "Player";
            Console.WriteLine(oyuncuAdi);

            // ------------EGZERSİZ 4------------
            // Adınızı ve yaşınızı birer değişkene atayıp ekranda konsola iki satır olarak şekilde yazdırınız.
            string Ad = "Zeynep";
            string Soyad = "Koz";
            int yas = 22;
            Console.WriteLine("Adım: "+ Ad + ", Soyadım: " + Soyad + ", Yaşım: " + yas);

            // Sabitler
            const int maksimumHiz = 5;
            Console.WriteLine(maksimumHiz);

            // integer toplama işlemi
            //int kazanilanPuan = 10;
            //int toplamPuan = oyuncuPuani + kazanilanPuan;
            //oyuncuPuani += oyuncuPuani;
            oyuncuPuani += 10;
            Console.WriteLine(oyuncuPuani);

            //int kaybedilenPuan = 15;
            //int toplamPuan = oyuncuPuani + kaybedilenPuan;
            //oyuncuPuani -= kaybedilenPuan;
            oyuncuPuani -= 15;
            Console.WriteLine(oyuncuPuani);

            oyuncuPuani *= 3;
            Console.WriteLine(oyuncuPuani);

            oyuncuPuani /= 9;
            Console.WriteLine(oyuncuPuani);


            // String Toplama İşlemi
            Console.WriteLine("Oyuncu Adı: " +  oyuncuAdi);

            // Sabitlerde İşlemler
            // maksimumHiz += 50; // sabit olduğu için altı kırmızı çizilir.

            Console.WriteLine("Oyuncu Adı: " + oyuncuAdi + "Oyuncu Puanı: " + oyuncuPuani);

            // ------------EGZERSİZ 5------------
            // Doğum yılınızı bir değişkene atayın ve yaşınızı içinde bulunduğunuz yıldan çıkartarak ekrana "Benim yaşım: 22" şeklinde tek satırda yazdırın.
            int dogumYili = 2003;
            int Yil = 2025;
            Console.WriteLine("Benim yaşım: " + (Yil - dogumYili));

            // Toplam Oynama Süresi (saniye)
            int toplamSaniye = 750;
            Console.WriteLine("Toplam Saniye: " + toplamSaniye);

            // Toplam Oynama Süresi (Dakika)
            float toplamDakika = 750 / 60f;
            Console.WriteLine("Toplam Dakika: " + toplamDakika);

            // Hesaplanan saniye
            float hesaplananSaniye = toplamDakika * 60;
            Console.WriteLine("Hesaplanan Saniye: " + hesaplananSaniye); // 30 saniyelik bir kayıp oldu int kullandığımız için float ile düzelttik.

            // ------------EGZERSİZ 6------------
            // Bir kenarı 21, diğer kenarı 23 cm olan dik üçgenin alanını hesaplayınız.
            float Alan = (21 * 23) / 2f;
            Console.WriteLine("Üçgenin alanı: " +  Alan);
        }
    }
}