using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_converting_veri_donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
            // int --> byte cevrilmesi
            int a = 5;
            byte b = (byte)a;
            Console.WriteLine(b);

            // string to int

            string sayi1 = "1";
            string sayi2 = "2";
            int a1 = int.Parse(sayi1);
            int b1 = int.Parse(sayi2);
            Console.WriteLine(a1);
            Console.WriteLine(b1);
            

            string sayi3 = "3";
            string sayi4 = "4";
            int c = Convert.ToInt32(sayi3);
            int d = Convert.ToInt32(sayi4);
            Console.WriteLine(c);
            Console.WriteLine(d);

            // int to string 
            int no1 = 5;
            int no2 = 10;
            string a3 = no1.ToString();
            string a4 = no2.ToString();
            Console.WriteLine(a3 + a4);

            // dobule to int 
            // Convert.To.Int32(***);


            // Kullanicidan alinan degerler(input) string veri tipinde olur her zaman
            Console.WriteLine("yasiniz kac");
            string kullanici_yas = Console.ReadLine();
            int kullanici_yasInt = int.Parse(kullanici_yas);
            int kullanici_yasInt2 = Convert.ToInt32(kullanici_yas);
            Console.WriteLine(kullanici_yasInt);
            Console.WriteLine(kullanici_yasInt2);
            */

            // exercise: kullanicidan 2 tane sayip alan ve ikisinin toplamini ekrana yazdir

            Console.WriteLine("birinci sayiyi giriniz");
            string sayi1 = Console.ReadLine();

            Console.WriteLine("ikinci sayiyi giriniz");
            string sayi2 = Console.ReadLine();

            int sayi_1 = int.Parse(sayi1);
            int sayi_2 = Convert.ToInt32(sayi2);
            int toplam = sayi_1  + sayi_2;
            Console.WriteLine("Iki sayinin toplami : " + (sayi_1 + sayi_2));



        }
    }
}
