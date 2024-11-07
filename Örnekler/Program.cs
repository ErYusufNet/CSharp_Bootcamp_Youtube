using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            // ## Carpim tablosu yapimi
            for(int i = 0; i<=10; i++)
            {
                for(int j = 0; j <= 10; j++)
                {
                    Console.WriteLine(i+"x"+j+"="+(i*j));
                }
            }
            Console.ReadLine();
            

            int hak = 3;
            while(true)
            {
                Console.WriteLine("Kullanici adinizi giriniz");
                string kullanici_adi = Console.ReadLine();
                Console.WriteLine("Sifrenizi giriniz");
                string sifre = Console.ReadLine();
                if (kullanici_adi == "yusuf" && sifre == "123")
                {
                    Console.WriteLine("Tebrikler basarili bir sekilde giris yaptiniz");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanici adiniz veya sifreniz yanlis*!");
                    if(hak >0)
                    {
                        hak = hak - 1;
                    }
                    if(hak ==0)
                    {
                        Console.WriteLine("Giris hakkiniz dolmustur");
                        break;
                    }
                }
            

         
            }
            */

            // kullanicidan sayi alicaz 0 dan baslayip aldigimiz sayiya kadar toplayacaz ve girdigi sayiyi
            //bolecegiz eger ortalama 50den buyukse ortlaam 50den buyuk degilde kucuktur yazdiricaz
            Console.WriteLine("sayiyi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
             for (int i = 0; i < sayi; i++)
            {
                toplam += i; // toplam=toplam+i
            }
             double ortalama = toplam/ sayi;
            if(ortalama>50)
            {
                Console.WriteLine("Ortalama 50den buyuktur");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ortalama 50 den kucuktur");
                Console.ReadLine(); 
            }



        }
    }
}
