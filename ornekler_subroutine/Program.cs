using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornekler_subroutine
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /* kullanicidan alinan sayi tek mi cift mi oldugunu bulalim
            Console.Write("Bir sayi giriniz ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            tekcift(sayi1);*/
            Console.Write("Ilk sayiyi giriniz ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikinci sayiyi giriniz ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            buyuksayi(sayi1, sayi2);

        }

        static void tekcift(int sayi)
        {
            if(sayi%2 == 0)
            {
                Console.WriteLine("Sayi cifttir");
            }
            else
            {
                Console.WriteLine("Sayi tektir");
            }
        }
        static void buyuksayi(int sayi1, int sayi2)
        {
            if(sayi1>sayi2)
            {
                Console.WriteLine("Sayi 1 daha buyuktur");
            }
            else if(sayi1 == sayi2)
            {
                Console.WriteLine("Sayilar esittir");
            }
            else
            {
                Console.WriteLine("Sayi 2 daha buyuktur");
            }
        }
    }
}
