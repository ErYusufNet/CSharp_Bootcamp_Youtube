using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salpaus__constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor = a speacial method in a class
            // same name as the class name 
            // can be used to assign arguments to fields when creating an object

            //create human class,name,surname,age,haircolor properties.Create constructor with parameters and assign them to the properties.
            //create a method in the human class that writes the name and surname age and haircolor to the console.


            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");
            car1.Drive();
            car2.Drive();
            Console.ReadLine();
            
            
        }
        class Car
        {
            string make;
            string model;
            int year;
            string color;

            public Car(string make, string model, int year, string color)
            {
                this.make = make;
                this.model = model;
                this.year = year;
                this.color = color;

            }

            public void Drive()
            {
                Console.WriteLine("You drive the " + make + " " + model);
            }


        }

    }
   
}
