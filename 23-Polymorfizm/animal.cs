using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Polymorfizm
{
    public class animal
    {
        public string name { get; set; }
        public animal(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setName()
        {
            this.name = name;
        }

        public virtual void sleep() //polymorfizim icin kullanilir bu virtual ile diger classlarda ezilip icerigi degissin
            //daha sonra bunu degistirmek icin override kullanilir
        {
            Console.WriteLine("Animal is sleeping");
        }
    }
}
