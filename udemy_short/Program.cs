using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_short
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //range = -32768 to 32767
            short a = -50;
            short b = 25550;
            short c = 3200;
            
            short maxValue = short.MaxValue;
            short minValue = short.MinValue;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
        }
    }
}
