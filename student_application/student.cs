using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_application
{
    public class student
    {
        private int studentNumber;
        private string name;
        private string surname;
        private int exam1;
        private int exam2;
        private int exam3;
        private string schoolName;

        public student(int studentNumber, string name, string surname, int exam1, int exam2, int exam3, string schoolName)
        {
            this.studentNumber = studentNumber;
            this.name = name;
            this.surname = surname;
            this.exam1 = exam1;
            this.exam2 = exam2;
            this.exam3 = exam3;
            this.schoolName = schoolName;
        }

        public void studentInfo()
        {
            Console.WriteLine("Student number " + studentNumber);
            Console.WriteLine("student name : " + name);
            Console.WriteLine("student surname : " + surname);
            Console.WriteLine("exam1 : " + exam1);
            Console.WriteLine("exam2 : " + exam2);
            Console.WriteLine("exam3 : " + exam3);
            Console.WriteLine("school name : " + schoolName);

        }

        public double calculateAverage()
        {
            double average = (exam1 + exam2 + exam3) / 3;
            return average;
        }
        public void getSchoolName()
        {
            Console.WriteLine("School name : " + schoolName);
        }
    }
}
