using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salpaus_static_variables
{
    public class Employee
    {
        /*
        public int employeeID;
        public string employeeName;
        public string employeeSurname;
        public static int salary;*/

        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public string employeeSurname { get; set; }
        public static int salary { get; set; }
    }
}
