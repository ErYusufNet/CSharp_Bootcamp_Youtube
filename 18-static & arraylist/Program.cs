using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_static___arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*static yapici metotlarda erisim belirleyici(public private olmaz)
             * parametre almazlar
             * bir kere calisir
             * kalitim ( inheritance yapilamaz)
             * icindeki tum propertyler statik olmak zorundadir
             * 
             
             */
            // statiklerde classdan obje/nesne turetmemize gerek yok 
            //ornek_public class musteri : public static void main{musteri.selamver();<}
            //burda tanimladigimiz bir sey daha sonra classtan uretilen tum objelerde gecerli olur 
            //statiklerin propertyleri de statik olmak zorundadir
            /* ornek:
             * public statik maas
             * 
             * employee e1 = new employee
             * employee e2 = new employee
             * 
             * burada iki employeenin de maasi ayni olur
             */
            employee e1 = new employee(1, " Yusuf ", 26);
            employee e2 = new employee(2, " John ",  33);
            
            e1.displayInfo();
            e2.displayInfo();
            employee.salaryIncrease(750);



        }
    }
}
