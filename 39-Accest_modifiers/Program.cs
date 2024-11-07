using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Accest_modifiers
{

    public class musteri
    {
        public string isim;
        public string soyisim;
        public int maas;
        public string cinsiyet;
        private int yas;//pr oldugu icin sadece bulundugu mevcut class icinde erisilebilir 
        public musteri()
        {   
            Console.WriteLine("Constructor musteri sinifi calisti");
        }


        // methodlar tanimlayalim
        public void musteribilgileri()
        {
            Console.WriteLine("isim :" + isim );
            Console.WriteLine("soyisim :" + soyisim);
            Console.WriteLine("maas :" + maas);
            Console.WriteLine("cinsiyet :" + cinsiyet);
            Console.WriteLine("yas :" + yas);
        }
        private void IsimSoyisimYazdir(string ad, string soyad)
        {
            Console.WriteLine("Musterinin adi :" +ad+ "musterinin soyad :" +soyad);
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // public , private,  bunlar nelerdir?
            musteri Musteri = new musteri(); // constructor kullanildi
            Musteri.isim = "Yusuf";
            Musteri.soyisim = "Er";
            Musteri.cinsiyet = "Erkek";
            Musteri.yas = 26; // yas özelligi private tanimlandigi icin erisilemez
            Musteri.maas = 4000;

        }
    }
}
