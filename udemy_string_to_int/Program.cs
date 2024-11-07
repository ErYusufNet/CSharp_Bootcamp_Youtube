using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_string_to_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number1 = "1";
            string number2= "2";
            /*int a = int.Parse(number1);
            int b = int.Parse(number2);*/
            int a = Convert.ToInt32(number1);
            int b = Convert.ToInt32(number2);
            Console.WriteLine(a+b);


        }
    }
}
