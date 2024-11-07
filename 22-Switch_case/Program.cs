using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace _22_Switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 700;
            Console.WriteLine("Atmye hosgeldiniz");
            Console.WriteLine("Lutfen bir islem seciniz ");
            Console.WriteLine("1-Bakiye göruntule");
            Console.WriteLine("2-para cek");
            Console.WriteLine("3-Para yatir");
            Console.WriteLine("4-Cikis yap");

            string secim=Console.ReadLine();
            switch (secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz :" + bakiye);
                    Console.ReadLine();
                    break;
                
                
                case "2":
                    Console.WriteLine("Cekmek istediginiz tutari giriniz");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                    if(cekilecek_tutar>bakiye)
                    {
                        Console.WriteLine("Bakiyenizden fazla para cekemezsiniz");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Kalan bakiyeniz :"+ (bakiye-cekilecek_tutar));
                        Console.ReadLine();
                    }
                    break;
                case "3":
                    Console.WriteLine("Yatirmak istediginiz tutari giriniz");
                    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine()) ;
                    Console.WriteLine("Yeni bakiyeniz :"+ (bakiye+yatirilacak_tutar));
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Cikis yapiliyor iyi gunler");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Lutfen gecerli bir deger giriniz");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
