using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Abstract_class
{
    internal class altclass : temelclass // inheritance yapmam icin abstract metotu override etmem lazim implement!
    {
        public override void metot2()
        {
            throw new NotImplementedException();
        }
    }
}
