using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Property
{
    public class customer
    {
        private string name;// private field/alan uretiyorum 

        public string _name // musterinin ozel olan fielda ulasip deger atamak icin property ozelligini kullaniyorum
        {
            get
            {
                return name; // name adli private degeri al döndur
            }
            set
            {
                name = value;// main kisminda tanimlanan deger burada value olarak otomatik gelir. name kismina value atandi.
            }
        }

    }
}
