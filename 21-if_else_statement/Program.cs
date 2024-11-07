using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_if_else_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("1.notunuzu giriniz");
            string not1 = Console.ReadLine();
            Console.WriteLine("2.Notunuzu gitiniz");
            string not2 = Console.ReadLine();
            Console.WriteLine("3.Notunuzu giriniz");
            string not3 = Console.ReadLine();
            int not_1 = int.Parse(not1);
            int not_2 = int.Parse(not2);
            int not_3 = int.Parse(not3);
            int ortalama = (not_1 + not_2 + not_3) / 3;

            if (ortalama >= 80 && ortalama <= 100)
            {
                Console.WriteLine("A+ ile basarili");
            }
            else if (ortalama <= 80 && ortalama >= 60)
            {
                Console.WriteLine("A");
            }
            else if (ortalama <= 60 && ortalama >= 40)
            {
                Console.WriteLine("b+");
            }
            else { Console.WriteLine("F"); }
            */

            // ## ATM Uygulamasi 
            // 1-bakiye goruntuleme,2-para cekme - 3-para yatirma - Q cikis 
            int bakiye = 100;

            Console.WriteLine("Yapmak istediginiz islemi seciniz");
            string secim = Console.ReadLine();
            
            
            if(secim=="1")
            {
                Console.WriteLine("Suanki bakiyeniz: " +bakiye);
            }
            else if(secim=="2")
            {
                Console.WriteLine("Cekmek istediginiz tutari giriniz");
                int cekilecek_tutar=Convert.ToInt32(Console.ReadLine());
                if(cekilecek_tutar<bakiye)
                {
                    Console.WriteLine("Kalan tutar: " + (bakiye - cekilecek_tutar));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bakiye yetersiz");
                    Console.ReadLine();
                }
               
            }
            else if(secim=="3")
            {
                Console.WriteLine("Yatirmak istediginiz tutari giriniz");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni bakiyeniz; " + (bakiye + yatirilacak_tutar)); Console.ReadLine();
            }
            else if(secim=="q")
            {
                Console.WriteLine("Cikis yapildi iyi gunler");
            }
            else { Console.WriteLine("Lutfen gecerli bir deger giriniz"); }


        }
    }
}
