using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salpaus_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age >= 25)
            {
                Console.WriteLine("You are allowed to enter the club and drink more then 2 coctails");
            }
            else if(age >=22)
            {
                Console.WriteLine("You are allowed to enter the club and drink 2 coctails!");
            }
            else if(age >=18)
            {
                Console.WriteLine("You are allowed to enter the club but you can only drink 1 coctail");
            }
            else
            {
                Console.WriteLine("You are not allowed to enter the club! You must be +18");
            }
            */

            Console.WriteLine("Are you coming to the party ? Yes or No ");
            string team = Console.ReadLine();
            if(team == "Yes")
            {
                Console.WriteLine("Great that you are coming !it is going to be fun!");
            }
            else if(team == "No")
            {
                Console.WriteLine("Oh I am sad to hear that !");
            }
            else
            {     
                Console.WriteLine("Error !!! Please enter Yes or No");
                      
            }
        }
    }
}
