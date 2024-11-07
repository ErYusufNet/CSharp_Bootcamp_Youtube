using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_to_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 5.22;
            int a = Convert.ToInt32(num1);
            // int b = int.Parse(num1)

            string age = Console.ReadLine();
            int age1 = int.Parse(age);
            int age2 = Convert.ToInt32(age);
            Console.WriteLine(age1);
            Console.WriteLine(age2);
        }
    }
}
