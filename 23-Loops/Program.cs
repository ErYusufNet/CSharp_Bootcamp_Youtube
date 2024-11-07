using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1 den 10'a kadar olan sayilari alt alta yazdiralim
            for(int i =1; i <=10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            // ornek 2 : 1 den 10'a kadar olan sayilardan cift olanlarini yazdiralim
            for(int a = 0; a<=10; a+=2) 
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
