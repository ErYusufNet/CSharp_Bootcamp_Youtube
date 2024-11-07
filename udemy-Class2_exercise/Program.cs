using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_Class2_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Mercedes = new Car();

            Mercedes.doorNo = 4;
            Mercedes.Model = "Maybach";
            Mercedes.Color = "Black";

            Mercedes.LockDoors();
            Mercedes.OpenDoors();

            Console.WriteLine("Car's door numbers: " + Mercedes.doorNo);
            Console.WriteLine("The model is : " + Mercedes.Model);
            Console.WriteLine("Car's color is : " + Mercedes.Color);
        }
    }
}
