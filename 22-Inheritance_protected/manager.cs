using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Inheritance_protected
{
    public class manager:employee
    {
        private int responsibleOf;
        public manager(int _id, string _name, string _surname, int _responsibleOf):base(_id,_name,_surname)
        {
            this.responsibleOf = _responsibleOf;

        }
        public void salaryRaise(int amount)
        {
            Console.WriteLine(getName() + " " +amount + " raised salarys!" );
        }

    }
}
