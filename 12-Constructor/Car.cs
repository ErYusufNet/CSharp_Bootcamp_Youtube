using System;

namespace _12_Constructor
{
    public class Car
    {
        public string brand;
        public int year;

        public Car(string _brand,int _year)
            /* burada constructor urettim ve parametrelerini classdaki taninlanmis ozelliklerle bagdastirdim.
             * daha sonra burada tanimladigim parametreleri classin icindeki ozelliklere atadim
             */
        {
            brand = _brand;
            year = _year;
        
        } 
       
    }
}
