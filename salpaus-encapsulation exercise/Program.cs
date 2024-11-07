using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salpaus_encapsulation_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we want to get our employee's social security number and perform the following checks;
            //set conditions:1= the social security number must be 11 characters long
            //all characters must be numeric
            //get condition: we will retrieve the first 5 characters of the social security number
            Employee e1 = new Employee();
            e1.SSNumber = "12345678901";
            Console.WriteLine(e1.SSNumber);

        }
    }
}
