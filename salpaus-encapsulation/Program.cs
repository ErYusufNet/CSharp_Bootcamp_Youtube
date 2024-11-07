using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salpaus_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // getter setter 
            student student1 = new student();
            student1.setName("Yusuf");
           
            string name = student1.getName();
            if(name == "Yusuf")
            {
                Console.WriteLine("it is working");
            }
            else
            {
                Console.WriteLine("it is not working");
            }
            Console.WriteLine(name);


        }
    }
}
