using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_constructor_uygulama1
{
    public class student
    {
        private int studentNo;
        private string studentName;
        private string studentSurname;
        private int exam1;
        private int exam2;
        private int final;
        private string schoolName;

        public student(int _studentNo,string _studentName,string _studentSurname,int _exam1,int _exam2,int _final,string _schoolName)
        {   
            studentNo = _studentNo;
            studentName = _studentName;
            studentSurname = _studentSurname;
            exam1 = _exam1;
            exam2 = _exam2;
            final = _final;
            schoolName = _schoolName;
        }


        //methods

        public void studentInfo()
        {
            Console.WriteLine(studentNo);
            Console.WriteLine(studentName);
            Console.WriteLine(studentSurname);
            
        }
        public double finalGrade()

        {
            double avarage = exam1 * 0.2 + exam2 * 0.2 + final * 0.6;
            return avarage;

        }
        public void schoolInfo()
        {
            Console.WriteLine(schoolName);
        }

    }
}
