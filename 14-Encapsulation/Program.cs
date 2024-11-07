using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Encapsulation
{
    internal class Program

    {
        static void Main(string[] args)
        {
            student myStudent = new student();
            myStudent.setAge(26);
            int studentNo = myStudent.getAge();
            myStudent.setName("Yusuf ");
            string studentName =myStudent.getName();
            Console.WriteLine(studentName  +  studentNo);

            Console.ReadLine();
        }
    }
}
