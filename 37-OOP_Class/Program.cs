using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_OOP_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();   // Araba classindan araba1 adli obje olusturduk
            //araba1 objesi artik Araba classinin icindekilere atandi 
            araba1.arabaRengi = "Siyah";
            araba1.arabaModel = "Toyota Corolla";
            araba1.kapiSayisi = 4;
            
             

            araba1.kapilariKilitle();
            araba1.arabaCalistir();
            araba1.arabaDurduruldu();
            Console.WriteLine(araba1.arabaModel + "'da " + araba1.kapiSayisi + "adet kapi vardir ve " + araba1.arabaRengi + " renktedir");

        }
    }
}
