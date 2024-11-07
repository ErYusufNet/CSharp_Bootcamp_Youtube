using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Polymorfizm
{
    public class dog:animal
    {
        public dog(string name) :base(name)
        { 

        
        }
        public override void sleep()
        {
            Console.WriteLine(getName() + " is havking ");
        }
    }
}
