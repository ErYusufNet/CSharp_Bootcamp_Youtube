using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Veya_operator
{
    internal class Program
    {
        static void Main(string[] args)


        {   // veya operatoru _ || = alt + <
            // iki kosuldan birinin true olmasi durumunda sonuc true cikar , her ikisi de false ise false cikar
            int sayi1 = 3;
            int sayi2 = 3;
            int sayi3 = 6;
            bool kontrolEt = sayi1 == sayi2 || sayi2 > sayi3;
            Console.WriteLine(kontrolEt);
        }
    }
}
