using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Arrays_data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            //string
            //double
            //char
            string[] isimler = { "Lahti", "Tampere", "Oulu", "Helsinki","Kouvala" };
            

            Console.WriteLine( isimler[0] +" is near to " + isimler[3] );
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            */
            /*
            double[] ondalikli_sayilar = { 1.44, 1.55, 1.66 };
            for (int i = 0; i < ondalikli_sayilar.Length; i++)
                // burda int i 0.indexden basliyor 
                // int i ondalikli sayilarin index sayisindan kucuk oldugu surece
                // i yi surekli 1 artir
            {
                Console.WriteLine(ondalikli_sayilar[i]);
            }
            */
            char[] karakter = { 'A', 'B', 'c' };
            for (int i = 0; i < karakter.Length; i++)
            {
                Console.WriteLine(karakter[i]);
            }
            
        }
    }
}
