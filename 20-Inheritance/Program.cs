using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // :diger class yazilir ve miras alinan classdaki propertyler,metotlar kullanilabilir
            cat myCat = new cat();
            myCat.name = "Papy";
            myCat.kilo = 4;
            myCat.leg = 4;
            myCat.color = "White";
            myCat.type = "Male";
            myCat.sleep();
            myCat.animalInfo();
        }
    }
    
}
