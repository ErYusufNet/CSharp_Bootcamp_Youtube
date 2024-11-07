using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_While_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den 10 a kadar olan sayilari ekrana yazdirin
            // 100den 0  a kadar olan sayilarin cift olanlarini buyukten kucuge yazdirin
            /*
            int a = 1;
            while(a<=10)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.ReadLine();
            */

            int a = 100;
            while (a >= 0)
            {
                Console.WriteLine(a);
                a = a - 2;
            }
        }
    }
}
