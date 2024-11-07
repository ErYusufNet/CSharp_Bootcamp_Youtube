using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Arttirma_Azalma_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arttirma operatoru : ++  = var olan degeri bir artirir
            // azaltma operatoru : -- = var olan degeri bir azaltir

            int sayi1 = 20;
            sayi1++;
            int sayi2 = 20;
            sayi2--;
           
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
        }
    }
}
