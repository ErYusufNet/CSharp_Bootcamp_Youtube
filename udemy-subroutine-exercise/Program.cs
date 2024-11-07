using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_subroutine_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Console.Write("Enter your number");
            int enteredNumber = int.Parse(Console.ReadLine());
            oddOrEven(enteredNumber);*/

            Console.Write("Enter the first number");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number");
            int n2 = int.Parse(Console.ReadLine());
            checkNumber(n1, n2);
        }
        // let user enter number
        // check the number is it odd or even number?
        static void oddOrEven(int number)
        {
            if(number%2==0)
            {
                Console.WriteLine("Number is even number");
            }
            else 
            {
                Console.WriteLine("Number is odd number");
            }
        }
        static void checkNumber(int a, int b)
        {
            if(a>b)
            {
                Console.WriteLine("1. number is bigger than 2. number");
            }
            else if(a ==b)
            {
                Console.WriteLine("Both numbers are equal");
            }
            else
            {
                {
                    Console.WriteLine("1. number is smaller than 2.number");
                }
            }
        }

        
    }
}
