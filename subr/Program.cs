using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greeting();
            Who();
            Plus(10, 20);
            Multiply(9, 11);

        }


        static void Greeting()
        {
            Console.WriteLine("Hello my name is Yusuf");
        }
        static void Who()
        {
            Console.WriteLine("Who are you?");
        }
        static void Plus(int number1, int number2)
        {
            Console.WriteLine("The result is :" +(number1 + number2));
        }
        static void Multiply(int n1,int n2)
        {
            Console.WriteLine("The result is: " + (n1 * n2));
        }

    }
}
