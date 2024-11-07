using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Arrays_dizeler_
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            // dizeler pythondaki list gibidir 
            // veri_tipi[] veri ismi = {""} seklindedir syntaxi
            string[] isimler = { "Ali", "Yusuf", "Mehmet", "Kenan"};
            foreach(string isim in isimler)
                
            {
                Console.WriteLine(isim);
            }
            */
            int[] sayilar = new int[4];
            sayilar[0] = 10;
            sayilar[1] = 20;
            sayilar[2] = 30;
            sayilar[3] = 40;
            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}
