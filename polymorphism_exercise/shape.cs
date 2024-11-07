using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_exercise
{
    public class shape //base class ust class bundan miras inheritance alinacak !
    {
        public string name { get; set; } 

        public shape(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
        public virtual void shapeCount()
        {
            Console.WriteLine("shape is counting");
        }
        public virtual void shapeInfo()
        {
            Console.WriteLine(getName());
        }
    }
}
