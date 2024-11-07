using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Esit_degildir_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esit degildir operatoru : !=
            int sayi1 = 3;
            int sayi2= 4;
            bool kontrolEt = sayi1 != sayi2;
            Console.WriteLine(kontrolEt);
        }
    }
}
