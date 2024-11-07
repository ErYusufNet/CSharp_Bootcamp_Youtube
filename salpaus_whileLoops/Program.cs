using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salpaus_whileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1 till 10
            int a = 1;
            while( a <=10)
            {
                Console.WriteLine(a);
                a++;
                
            }
            Console.ReadLine();
            */
            //100 till 0 and only even numbers = 2,4,6,8,10,12...
            int a = 100;
            while(a>=0)
            {
                Console.WriteLine(a);
                a -= 2; // a = a-2
            }
            Console.ReadLine();


        }
    }
}
