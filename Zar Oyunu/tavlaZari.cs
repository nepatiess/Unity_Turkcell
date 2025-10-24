using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zar_Oyunu
{
    internal class tavlaZari
    {
        /// <summary>
        /// Zarın alabileceği maksimum değer değişkeni
        /// </summary>
        int maksimumZarDegeri;

        Random random = new Random();

        /// <summary>
        /// Zarın alabileceği maksimum değeri giriniz.
        /// </summary>
        /// <param name="maksimumZarDegeri"></param>
        public tavlaZari(int maksimumZarDegeri)
        {
            // değişken               
            this.maksimumZarDegeri = maksimumZarDegeri;
        }

        public int ZarAt()
        {
            // Rastgele sayı üret.

            return random.Next(1, maksimumZarDegeri + 1 );
        }
    
    
    
    
    
    }
}
