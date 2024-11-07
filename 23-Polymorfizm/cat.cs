using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _23_Polymorfizm
{
    public class cat :animal
    {
        public cat(string name) :base(name)
        { 
            
        
        }
        public override void sleep()//virtual anahtarini bagladigim metotu burada degistirebilmem icin override yapiyorum
        {
            Console.WriteLine(getName() + " is eating");
        }
    }
}
