using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Inheritance_Sealed
{
    internal class employee:customer
    {
        public int employee_id { get; set; }
        public int employee_salary { get; set; }
        public string employee_name { get; set; }
        public string employee_surname { get; set; }

        public void personelInfo()
        {
            Console.WriteLine(employee_id + employee_name + employee_name + employee_surname);
        }
    }
}
