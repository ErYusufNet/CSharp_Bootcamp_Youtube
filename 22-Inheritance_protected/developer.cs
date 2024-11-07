using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Inheritance_protected
{
    public class developer : employee
    {
        private string skills;
        public developer(int id, string name, string surname, string _skills) : base(id, name, surname)
        {
            this.skills = _skills;

        }

        public void coding(string _code)
        {
            Console.WriteLine(getName() + _code);

        }
    }
}

