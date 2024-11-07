using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Constructor
{
    
   
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             A constructor in C# is a special method inside a class that gets called when you create an instance of that class.
            Its main job is usually to initialize the fields of the class, set up any necessary resources, or perform other setup tasks.
            Constructors have the same name as the class and do not have a return type. If a class doesn't have any constructors defined, 
            C# compiler automatically adds a default constructor for it.
             */
            // ctor = short version

            Car myCar = new Car("mercedes",2024);// parametreler ile classin icindeki ozellikler bagdastirildi
            Console.WriteLine("My car is " +myCar.brand + " and it is " + myCar.year + " model");



        }
    }
}
