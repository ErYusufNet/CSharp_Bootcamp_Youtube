using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1 den 10 a kadar olan sayilari yazdirirken belirli bir sayiya gelince
             durmasini istiyorsak break kelimesini kullaniriz */
            for(int a = 0; a<=10; a++)
            {
                if(a==7)
                {
                    break;
                }
                Console.WriteLine("a ' nin degeri :" +a);
            }
        
            Console.ReadLine();
            /* continue = belirlenen degeri atlar döngu devam eder
              mesela 1 den 10 a kadar olan sayilari yazdiralim 7 yi atlasin */

            for(int b = 0; b<=10; b++) 
            { 
                if(b==7)
                { 
                    continue;
                }
                    
            }

        }

    }
}
