using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // arraylist classindan obje olusturup sonrasinda bu objeye tanimlanmis hazir metotlari kullaniriz(add,remove vs)
            ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add("Yusuf");
            koleksiyon.Add("Miko");
            koleksiyon.Add("John");
            koleksiyon.Add("Johnny");
            int count = koleksiyon.Count;
            //belirli bir indexden sonra ekleme yapma 
            koleksiyon.Insert(1, "Micheal");
            //numaralarda kucukten buyuge siralayan .Sort metodu vardir
               
            koleksiyon.Remove("Johnny");
            bool control = koleksiyon.Contains("Minna");

             

            foreach (var name in koleksiyon)
            {
                Console.WriteLine(name );
               

            }
            Console.WriteLine("There is " + count + " items in the arraylist");
            Console.WriteLine("Is there Minna in the list ? " + control);

        }
    }
}
