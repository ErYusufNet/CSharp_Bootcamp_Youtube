using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Polymorfizm
{
     class Program
    {
        static void Main(string[] args)
        {
            animal pet = new animal("Polly");
            pet.sleep();

            cat myCat = new cat("Porry");
            myCat.sleep();

            dog myDog = new dog("Pommy");
            myDog.sleep();
        }
    }
}
