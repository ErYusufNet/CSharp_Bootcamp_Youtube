using System;

namespace _17_Encapsulation_uygulama
{
    public class employee
    {
        private string phoneNumber; // Employee sınıfının private bir string alanı. 

        public string _phoneNumber // phoneNumber alanına erişimi sağlayan public bir özellik (property).
        {
            get
            {
                // phoneNumber stringinin 1. indeksinden başlayarak 5 karakteri alır ve döndürür.
                return phoneNumber.Substring(0, 5)+"******";//ilk 5 endex sonrasini sansurluyoruz.
            }
            set
            {
                bool control = false; // Kontrol değişkeni başlangıçta false olarak ayarlanır.

                // value parametresinin uzunluğu 11 ise, telefon numarasının doğruluğunu kontrol et.
                if (value.Length == 11)
                {
                    // value içindeki her karakterin bir rakam olup olmadığını kontrol et.
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool IsItNumber = char.IsNumber(value[i]); // IsNumber metodunu kullanarak karakterin bir rakam olup olmadığını kontrol eder.
                        if (IsItNumber)
                        {
                            // Eğer karakter bir rakamsa herhangi bir işlem yapmaz.
                        }
                        else
                        {
                            control = true; // Eğer bir karakter bir rakam değilse, kontrol değişkenini true yap ve döngüyü sonlandır.
                            break;
                        }
                    }
                    // Eğer control değişkeni true ise, telefon numarasının hatalı olduğunu belirtir.
                    if (control)
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        phoneNumber = value; // Telefon numarası doğruysa, phoneNumber alanını value parametresi ile günceller.
                    }
                }
                else
                {
                    // Eğer value parametresinin uzunluğu 11 değilse, telefon numarasının 11 karakterden oluşması gerektiğini belirtir.
                    Console.WriteLine("the phone number should consist of 11 characters");
                }
            }
        }
    }
}
