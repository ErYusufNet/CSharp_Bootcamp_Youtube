using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _41_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir nesnin icerdigi verileri ve bu verilere erisim saglayan metotlari bir arada
             * gruplandirma ve bu gruplara erisimi kontrol etme prensibidir.Bir nesnenin ic 
             * detaylarini gizleme ve sadece belirlenen arayuz izerinden erisime izin verme yontemidir
             * bu nesnenin ic yapisinin disaridan gelen mudahalelere karsi korunmasini saglar */
            ogrenci ogrenci1 = new ogrenci();
            ogrenci1.setIsim("Yusuf");
            ogrenci1.getIsim();
             
             
        }
    }
}
