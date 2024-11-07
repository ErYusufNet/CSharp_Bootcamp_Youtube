using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_OOP_Class
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;

        public void arabaCalistir()
        {
            Console.WriteLine("Araba calistirildi");
        }
            
        public void arabaDurduruldu()
        {
            Console.WriteLine("Araba durduruldu");
        }
        public void kapilariKilitle()
        {
            Console.WriteLine("Kapilar kilitlendi");
        }


    }
}
