using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_subroutine_return
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int resultReturn = Plus(6, 10);
            if(resultReturn > 15)
            {
                Console.WriteLine("Number is bigger than 15");
            }
            else
            {
                Console.WriteLine("Number is lower than 15");
            }
            string Person = nameSurname("Yusuf", "Er");
            Console.WriteLine(Person);
            
        }
        static int Plus(int n1, int n2)
        {
            int result = n1 + n2;
            return result;

        }
        static string nameSurname(string name, string surname)
        {
            return name + " " + surname;
        }
    }
}
