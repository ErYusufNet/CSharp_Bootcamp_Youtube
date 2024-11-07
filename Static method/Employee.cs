using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_method
{
    public class Employee
    {
        public static void nameSurname()
        {
            Console.WriteLine("John Doe");

        }
        public static void numbers(int n1, int n2)
        {
            Console.WriteLine("The result is : " + (n1 + n2));
        }
    }
}
