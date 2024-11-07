using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_constructor_uygulama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool control = true;
            student myStudent = new student(1997, "Yusuf", "Er", 90, 80, 95, "Lab");
            Console.WriteLine("Welcome what would you like to do?");
            

            while (control)
            {
                showtransactions();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case  "1":

                       myStudent.studentInfo();
                        break;
                    case "2":
                        double studentAvarage = myStudent.finalGrade();
                        Console.WriteLine(studentAvarage);
                        break;
                    case "3":
                        myStudent.schoolInfo();
                        break;
                    case "4":
                        control = false;
                        break;

                }

            }



        }

        static void showtransactions()
        {
            Console.WriteLine("1-Show student ınformatıons");
            Console.WriteLine("2-Student avarage grade");
            Console.WriteLine("3-Show student's school");
            Console.WriteLine("4-Exit");
        }
    }
}
