using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Subroutines
{
    internal class Program
    // mevcut olan static void'in altina bir static void daha acilir daha sonra yanina tanimayacagimiz seyin adi yazilir
    // altina yapilacak islemler yazilir ve daha sonra ustteki mevcut static voidin icine tanimladigimiz seyin adi yazilir ve print yapilir.
    {
        static void Main(string[] args)
        {
            // greeting();
            SelamVer();
            AdiniYazdir();

        }
        static void greeting()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello ! How are you? " + name);
        }
        static void SelamVer()
        {
            Console.WriteLine("Selamlar ");
            Console.ReadLine();

        }
        static void AdiniYazdir()
        {
            Console.WriteLine("Benim adim Yusuf Er");
            Console.ReadLine();
        }
    }
}
