using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          * string[] isimler = { "Yusuf", "Ali", "Ömer" };
            foreach(string a in isimler)
            {
                Console.WriteLine(a);
            }
                              // listenin icindeki degerleri tek tek alt alta yazdirir. pythondaki range gibidir
            */

            double[] sayilar = { 1.5, 1.4, 1.3 };
            foreach (double i in sayilar)
            {

                Console.WriteLine(i);
            }

        }
    }
}
