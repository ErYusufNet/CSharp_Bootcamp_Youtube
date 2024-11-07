using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _19_Kullanicidan_deger_alma_input_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // readline
            Console.WriteLine("Lutfen adinizi giriniz");
            string isim = Console.ReadLine();
            Console.WriteLine("soyisim giriniz");
            string soyisim = Console.ReadLine();
            Console.WriteLine("hangi takimlisin");
            string takim = Console.ReadLine();
            Console.WriteLine("hangi sehirde yasiyorsun");
            string sehir = Console.ReadLine() ;
            Console.WriteLine("Hangi okulda okuyorsun?");
            string okul = Console.ReadLine() ;

            Console.WriteLine("Kullanicinin ismi " + isim + " soyismi " + soyisim +  " yasadigi sehir : " + sehir + " tuttugu takim : " + takim +" okudugu okul : " + okul);














        }
    }
}
