using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*we will have a student with variables for student number,first name,last name,exam1,exam2,exam3
             * school name.the acces modifieres will be private.we will assign values to these variables using a constructor
             * there will be 'showstudentInfo()' method that will print the student info to the console.
             * there will be a 'calculateAverage()' method to calculate the student's average grade,
             * there will be a getschoolName() method that will retrieve the school name.
             * based on the student's choice,we will perform the following operations:
             * 1-show student information
             * show student's average grade
             * learn the student's school name
             * exit
             */
            bool control = true;
            student student1 = new student(1, "John", "Doe", 80, 90, 70, "Harvard");
            Console.WriteLine("Welcome..What would you like to do ");
            while(control)
            {
                options();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        student1.studentInfo();
                        break;
                    case 2:
                        Console.WriteLine("Student's average grade : " + student1.calculateAverage());
                        break;
                    case 3:
                        student1.getSchoolName();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye..");
                        return;
                    default:
                        Console.WriteLine("Invalid choice..");
                        break;
                }
            }

            
        }
        static void options()
        {
            Console.WriteLine("1-Show student information");
            Console.WriteLine("2-Show student's average grade");
            Console.WriteLine("3-Learn the student's school name");
            Console.WriteLine("4-Exit");
        }
    }
}
