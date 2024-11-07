using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Kullanicinin_girdigi_deger_arrays_icinde_varmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*kullanicinin girdigi sayi dizinin icinde var mi? kontrol eden ,varsa kac tane oldugnu soyleyen yoksa da yoktur
              diye uyaran programi yazalim
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 3, 5, 6, 7, 11, };
            int adet = 0;
            int sayi;
            Console.Write("Lutfen bir sayi giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayi == sayilar[i])
                { 
                    adet++;
                }
            }
            if (adet == 0)
            {
                Console.WriteLine("Girdiginiz sayi dizide bulunamadi");
            }
            else
            {
                Console.WriteLine("Girdiginiz sayi dizide bulundu");
                Console.WriteLine("Adet : " + adet);
            }
            */

            // kullanicidan alinan degerlerin ustunde matematik islemleri yapma !
            /* kullanicidan 10 tane int deger al
             * kac adet tek,kac adet cift rakam var
             * cift degerlerin toplami,tek degerlerin toplami
             * son olarak kontrol yapsin cift degerlrein toplami tek degerlerden buyukse cift degerlerin toplami buyuktur yazdirsin
             * eger teklerin toplami buyukse onu yazdir
             */
            // 10 elemanlı bir integer dizisi oluşturuluyor.
            int[] sayilar2 = new int[10];

            // Tek ve çift adetler için toplam değişkenleri tanımlanıyor.
            int tekAdetToplam = 0;
            int ciftAdetToplam = 0;

            // Tek ve çift sayıların toplam değişkenleri tanımlanıyor.
            int TekSayilarinToplami = 0;
            int CiftSayilarinToplami = 0;

            // Kullanıcıdan alınan değeri tutacak değişken.
            int kullaniciDeger;

            // Diziye kullanıcının girdiği değerleri atama işlemi yapılıyor.
            for (int i = 0; i < sayilar2.Length; i++)
            {
                // Kullanıcıdan i. index değerini girmesini isteyen bir mesaj yazdırılır.
                Console.Write((i + 1) + ". index değerini giriniz: ");

                // Kullanıcının girdiği metni okuyup, bu metni bir tam sayıya dönüştürür ve kullaniciDeger'e atar.
                kullaniciDeger = Convert.ToInt32(Console.ReadLine());

                // Döngü içinde her bir adım için dizinin bir elemanını kullanıcının girdiği değerle günceller.
                sayilar2[i] = kullaniciDeger;
            }

            // Dizideki elemanları kontrol ederek tek ve çift sayıları ayırma işlemi yapılıyor.
            for (int j = 0; j < sayilar2.Length; j++)
            {
                // Eğer dizinin j. elemanı 2'ye bölündüğünde kalan sıfırsa, bu bir çift sayıdır.
                if (sayilar2[j] % 2 == 0)
                {
                    // Çift adet sayısını bir artır.
                    ciftAdetToplam++;

                    // Çift sayıları toplamı güncelle.
                    CiftSayilarinToplami += sayilar2[j];
                }
                else
                {
                    // Eğer dizinin j. elemanı 2'ye bölündüğünde kalan sıfır değilse, bu bir tek sayıdır.
                    // Tek adet sayısını bir artır.
                    tekAdetToplam++;

                    // Tek sayıları toplamı güncelle.
                    TekSayilarinToplami += sayilar2[j];
                }
            }

            // Çift ve tek sayıların toplamları karşılaştırılıyor.
            if (CiftSayilarinToplami > TekSayilarinToplami)
            {
                Console.WriteLine("Çift sayıların toplamı daha büyüktür.");
            }
            else
            {
                Console.WriteLine("Tek sayıların toplamı daha büyüktür.");
            }

            // Sonuçlar ekrana yazdırılıyor.
            Console.WriteLine("*************************************");
            Console.WriteLine("Çift sayıların toplamı: " + CiftSayilarinToplami);
            Console.WriteLine("Çift sayıların adedi: " + ciftAdetToplam);
            Console.WriteLine("Tek sayıların toplamı: " + TekSayilarinToplami);
            Console.WriteLine("Tek sayıların adedi: " + tekAdetToplam);



        }
    }
}
