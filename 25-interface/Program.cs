using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_interface
    /*interface icinde metotlar tanimlariz classlarda icerigini doldururz
     * interface icindeki metotlarin erisim belirleyicisi ve icerigi olamaz
     * interface inheritance yapan tum classlar icerisinde tanimlanan tum metotlari implement etmek zorundalar
     * bir class sadece bir classdan uretilirken bir class bircok interfaceden uretilebilir
     * interfacelerde projeye class degil component eklenir interface secilir
     * interfaceden obje olusturulamaz
     * class interfaceyi inheritance yaptiginda obje turetilirken o zaman solda interface kullanilabilir
     */ 
     
     
{
    internal class Program
    {
        static void Main(string[] args)

        {
            customer newCustomer = new customer();
            newCustomer.customerDelete();
            newCustomer.customerUpdate();
            newCustomer.customerAdd();
            newCustomer.customerRemove();
            ICustomer cs1 = new customer();
        }
    }
}
