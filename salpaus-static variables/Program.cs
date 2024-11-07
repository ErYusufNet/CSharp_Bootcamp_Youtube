using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salpaus_static_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Employee e1 = new Employee();
            e1.employeeID = 1;
            e1.employeeName = "John";
            e1.employeeSurname = "Doe";
            Employee.salary = 2500; */
            Employee e1 = new Employee();

            Console.WriteLine("Employee's id: " + e1.employeeID);
            Console.WriteLine("Employee's name: " + e1.employeeName);
            Console.WriteLine("Employee's surname: " + e1.employeeSurname);
            Console.WriteLine("Employee's salary: " + Employee.salary);
        }
    }
}
