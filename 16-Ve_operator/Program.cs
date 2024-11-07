using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Ve_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // && ve operatoru
            int sayi1 = 5;
            int sayi2 = 5;
            int sayi3 = 10;
            // verilen tum kosullar saglanirsa true ile sonuclanir.

            bool kontrolEt = sayi1 == sayi2 && sayi1 > sayi3;  // burada sayi1 ve sayi2 ayni esit. daha sonra ve operatoru geliyor ; sayi1, sayi3ten buyuktur diyor.bu yanlis o yuzden false

            Console.WriteLine(kontrolEt);
        }
    }
}
