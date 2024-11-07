using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_while_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            // while do whiledan ayiran tek fark while do da kosul saglanmasa da bir kere döner
            // 1 den 10 a kadar olan sayilari do while ile yazdiralim
            // 1 den 100 e kadar olan sayilarin toplamini do while ile yazalim
            int a = 1;
            do
            {
                Console.WriteLine(a); // a yadiriliyor yani 1 
                a++; // a 1 artirilip 2 oluyor 
                
         
            } while (a <= 10);// a sayisi 2 oldu hala 10 dan kucuk basa donup dongu devam ediyo
            */

            int a = 1;
            int toplam = 0;

            do
            {
                // a 1 iken toplam a ya ekleniyor sonra dongu basa donuyor

                toplam = toplam + a; // a degerini toplamin icine koy 
                a++;// a 1 artirildi 2 oldu 

            } while (a <= 100);
            Console.WriteLine("1 den 100 e kadar olan sayilarin toplami :" +toplam);

        }
    }
}
