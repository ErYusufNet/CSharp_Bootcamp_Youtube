using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Inheritance
{
    internal class cat:dog
    {
        public void sleep()
        
        {
            Console.WriteLine("animal is sleeping!");

        }
        public void animalInfo()
        {
            Console.WriteLine("Animal's name is : " + name);
            Console.WriteLine("Animal's color is : " + color);
            Console.WriteLine("Animal's kilo is " + kilo);
            Console.WriteLine("animals has : " + leg + " legs");
            Console.WriteLine("Animal is : " + type);
        }
    }
}
