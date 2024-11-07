    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_static___arraylist
{
    public class employee
    {
        private int id{ get; set; }
        private string name { get; set; }
        private int age { get; set; }

        private static int salary { get; set; }

       public employee(int _id,string _name,int _age) // constructor ile private propertylere erisiyoruz.
        {   
            id = _id;
            name = _name;
            age = _age;
            
            
        }
        static employee()
        {
            salary = 2500;
        }
        public void displayInfo()
        {
            Console.WriteLine( id + name + age);
        }
        public static void salaryIncrease(int amount)
        {
            Console.WriteLine("a salary increase is being given");
            Console.WriteLine("Current salary is : " + (salary + amount));
        }

    }
}
