using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Class_uygulama1
{
    namespace OgrenciUygulamasi
    {
        public class Ogrenci
        {
            private int ogrno;

            private string isim;

            private string soyisim;

            private int vize1;

            private int vize2;

            private int final;

            private string okulIsmi;



            public Ogrenci(int _ogrno, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okulIsmi)
            {
                ogrno = _ogrno;
                isim = _isim;
                soyisim = _soyisim;
                vize1 = _vize1;
                vize2 = _vize2;
                final = _final;
                okulIsmi = _okulIsmi;
            }


            public void ogrenciBilgileriGoster()
            {
                Console.WriteLine("Öğrenci Numarası : " + ogrno);
                Console.WriteLine("Öğrenci İsmi : " + isim);
                Console.WriteLine("Öğrenci Vize1 : " + vize1);
                Console.WriteLine("Öğrenci Vize2 : " + vize2);
                Console.WriteLine("Öğrenci Final : " + final);
                Console.WriteLine("Öğrenci Okul İsmi  : " + okulIsmi);

            }


            public double ogrenciNotuBul()
            {
                double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;

                return ortalama;
            }


            public void okulGetir()
            {
                Console.WriteLine("Öğrencinin Okul İsmi : " + okulIsmi);
            }



        }
    }


    namespace _40_Class_uygulama1
    {
        using OgrenciUygulamasi; // Add this line

        class Program
        {
            static void Main(string[] args)
            {
                bool kontrol = true;
                Ogrenci ogrenci1 = new Ogrenci(1, "Enes", "Bayram", 50, 40, 73, "Doğuş Üniversitesi");

                Console.WriteLine("Uygulamamıza hoşgeldiniz... Yapmak istediğiniz işlemi seçiniz");

                while (kontrol)
                {
                    islemleriGoster();
                    string secim = Console.ReadLine();

                    switch (secim)
                    {
                        case "1":
                            ogrenci1.ogrenciBilgileriGoster();
                            break;
                        case "2":
                            double ogrenciOrtalama = ogrenci1.ogrenciNotuBul();
                            Console.WriteLine("Öğrencinin Ortalaması :" + ogrenciOrtalama);
                            break;
                        case "3":
                            ogrenci1.okulGetir();
                            break;
                        case "4":
                            kontrol = false;
                            break;
                    }
                }
            }

            static void islemleriGoster()
            {
                Console.WriteLine("1- Öğrenci Bilgileri Göster");
                Console.WriteLine("2- Öğrenci Ortalamasını Göster");
                Console.WriteLine("3- Öğrenci Okulunu Göster");
                Console.WriteLine("4- Çıkış yap");
            }
        }
    }
}
