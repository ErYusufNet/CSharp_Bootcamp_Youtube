using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_variables_data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte x = 5;
            byte a = 25;
            byte b = 10;  //0-255

            byte maxValue = byte.MaxValue;
            byte minValue = byte.MinValue;

            Console.WriteLine(x);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
        }
    }
}
