using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_Alma_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // mod alma operatoru : % bir sayiyi bir sayiya böldugumuzde , bölumunden kalani verir
            // bölumden kalani alma !
            int sayi1 = 10;
            int sayi2 = 3;
            int sonuc = sayi1 % sayi2;
            Console.WriteLine(sonuc);
            Console.WriteLine(sayi1%sayi2);
            Console.ReadLine();
        }
    }
}
