using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Subroutines_kullanicidan_deger_alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Karesini almak istediginiz sayiyiyi giriniz ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int karesi_sonuc = karesinialma(sayi1);
            Console.WriteLine("Girdiginiz sayinin karesi : " + karesi_sonuc);
            if(karesi_sonuc >50)
            {
                Console.WriteLine("Girdiginiz sayinin karesi 50'den buyuktur");
            }
            else
            {
                Console.WriteLine("Girdiginiz sayinin karesi 50'den kucuktur");
            }
        }


        static int karesinialma(int x)
        {
            int karesi = x * x;
            return karesi;
        }
    }
}
