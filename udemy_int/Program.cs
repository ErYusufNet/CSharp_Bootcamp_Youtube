using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 byte 
            //range = -2.147.483.648 to 2.147.483.647

            int a = 150000;
            int b = -50000;
            int maxValue = int.MaxValue;
            int minValue = int.MinValue;

            Console.WriteLine(a);
            Console.WriteLine(b); 
            Console.WriteLine(minValue);

            Console.WriteLine(maxValue);

        }
    }
}
