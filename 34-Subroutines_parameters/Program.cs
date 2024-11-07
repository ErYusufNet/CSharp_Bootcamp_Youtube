using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Subroutines_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Subroutine baska alt bir static icine islemleri yaptirilip daha sonra ana static icinde islemi yaptirilir
            //Parametre alan ancak geriye deger dondurmeyen subroutine yazdirma
            // parametrelerde girilen degerler baska bir metoddaki deger ile ayni isimde olabilir bunlar karismaz!
            /*sonradan acilan static void icine parantez icinde veri tipi ve deger ismi verilir, daha sonra 
             asagiya inilip consol icine yapilacak islem yazilir ve parametre degerler parantez icinde verilir
            daha sonra yukardaki main void icerisine bu tanimlanan metot isimleri yazilir parantez icine parametre degerleri girilir*/
            toplamaYap(5, 6);// tanimlanan subroutine ismi yazilir parantez icine de gerekli parametre degerleri(sayilari)girilir
            carpmaYap(3, 5, 2);
            isimSoyisim("Yusuf", "Er"); // stringlerde tirnak icinde yazdirilir

        }
        static void toplamaYap(int sayi1 , int sayi2)// isim tanimlanir ve parantez icine once veri tipi sonra deger ismi yazilir
            // parantez icine birden cok deger girilebilir

        {
            Console.WriteLine("Girilen sayilarin toplami :" + (sayi1 + sayi2));
            // yapacagimiz islemi consol icine yazdiirp sonra + isareti ekleyip parantez icine de parametre isimleri yazilir
        }

        static void carpmaYap(int sayi1, int sayi2, int sayi3)
        {
            Console.WriteLine("Girilen sayilarin carpimi " + (sayi1*sayi2*sayi3));
        }

        static void isimSoyisim(string isim, string soyisim)
        {
            Console.WriteLine("isim ve soyisim :"+isim + " "+soyisim);// stringlerde parantez icine alinmaz
        }
    }
}
