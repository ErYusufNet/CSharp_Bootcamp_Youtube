using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Abstract_class
{
    //interfacede oldugu gibi icerigi olmayan metotlar uretebilir ancak erisimden sonra abstract anahtar kelime eklenmeli

    public abstract class temelclass
    {
        public void metot1()//metotun budysi(icerigi)
        {
            Console.WriteLine("metot1 calisti");
        }

        public abstract void metot2();//metotun imzasi
    }
}
