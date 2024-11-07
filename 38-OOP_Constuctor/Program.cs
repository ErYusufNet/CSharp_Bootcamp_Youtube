using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _38_OOP_Constructor
{
    // Araba sınıfı tanımlanıyor.
    class Araba
    {
        // Araba özellikleri tanımlanıyor: model, yıl, fiyat.
        public string model;
        public int yil;
        public int fiyat;

        // Constructor (yapıcı metod) oluşturmak için ctor yazıp Tab + Tab tuşlarına basıyoruz.
        // Bu constructor, Araba sınıfının bir örneği oluşturulduğunda otomatik olarak çağrılır.
        public Araba(int ucret , string marka, int sene)
        {
            model = marka;
            yil = sene;
            fiyat = ucret;
            // Constructor çağrıldığında ekrana bir mesaj yazdırılıyor.
            Console.WriteLine("Araba sınıfının constructor'u çalıştırıldı");
        }

        // Araba'nın satın alındığını belirten bir metot.
        public void satinAlindi()
        {
            // Ekrana satın alma mesajları yazdırılıyor.
            Console.WriteLine("Araba satın alındı");
            Console.WriteLine("Yeni arabanız hayırlı olsun");
        }

        // Araba'nın ödeme yapıldığını belirten bir metot.
        public void ödemeyap()
        {
            // Ekrana ödeme bilgisi ve başarı mesajları yazdırılıyor.
            Console.WriteLine("45.000€ ödemeniz gerekiyor");
            Console.WriteLine("Ödeme gerçekleşti");
        }
    }

    // Program başlıyor.
    internal class Program
    {
        // Ana giriş noktası: Programın başladığı yer.
        static void Main(string[] args)
        {
            /* 
               Constructor, yani yapıcı metotlar: 
               Classlardan obje oluşturduğumuzda otomatik olarak çağrılan ve geriye bir değer dönmeyen metotlardır.
               Herhangi bir veri tipi almazlar, adları class ile aynı olmalıdır.
               Örneğin:
               public class Araba
               {
                   public Araba()
               }
            */

            // Araba sınıfından araba1 adında bir örnek oluşturuluyor.
            Araba araba1 = new Araba(4500, "mercedes", 2023);
            // araba classinda tanimlanan constructorlari parametre icinde veriyoruz
            

            

            // Kullanıcıya araba bilgileri verilip satin almak istiyor mu soruluyor.
            Console.WriteLine(araba1.model + "," + araba1.yil + " model " + araba1.fiyat + "€'ya almak istiyor musunuz? ");
            string al = Console.ReadLine();

            // Kullanıcının cevabına göre işlemler yapılıyor.
            if (al.ToLower() == "evet")
            {
                // Araba ödeme yapma ve satın alma işlemleri gerçekleştiriliyor.
                araba1.ödemeyap();
                araba1.satinAlindi();
            }
            else
            {
                // Kullanıcı "evet" demezse ekrana başka bir mesaj yazdırılıyor.
                Console.WriteLine("Daha sonra tekrar bekleriz!");
            }

            // Console.ReadKey() eklenerek konsol penceresinin kapatılmasını bekliyoruz.
            Console.ReadKey();
        }
    }
}
