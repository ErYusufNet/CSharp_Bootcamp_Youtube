using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Subroutines_return
{
    internal class Program
    {
        static void Main(string[] args) // void geriye deger dondurmeyen veri tipidir.Return yapmiyorsak void yazilir
        {
            // x  ve y degerlerini kullanicidan alma yontemi ! 
            Console.Write("Enter first number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number ");
            int num2 =Convert.ToInt32(Console.ReadLine());
            int result = toplamaYap(num1, num2);
            Console.WriteLine(num1 + " ve " + num2 + " sayilarinin toplami " + result + "eder"); */

           /* int donendeger = toplamaYap(6, 7);
            if(donendeger>10)
            {
                Console.WriteLine("Donen deger 10'dan buyuktur");
            }
           */



        }

        static int toplamaYap(int x, int y) // return yapacagimiz icin veri tipini int yazdik
        {
            int sonuc = x + y;
            return sonuc;
            //return degerleri döndurur
            // returndan sonra yazilan hicbir kod calismaz - return metodu bitiren kelimedir
        }
    }
}
