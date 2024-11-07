using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Encapsulation_uygulama
{
    internal class Program
    {
        static void Main(string[] args)

            /*Create employee class 
             * setter cond:the phone number should consist of 11 characters 
             * all characters should be numerical
             * getter cond:retrieve only first 5 characters.
             */
        {

            employee employee1 = new employee();
            employee1._phoneNumber = "12345678912";
            Console.WriteLine(employee1._phoneNumber);
        }
    }
}
