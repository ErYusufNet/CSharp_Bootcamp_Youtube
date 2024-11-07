using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;


namespace _42_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /* StringBuilder bir classdir degerleri ve metotlari bulunur.
             * StringBuilder yazacagimiz zaman en uste using System.Text; yazdirmamiz lazim
             * StringBuilder stringleri degistirmek icin kullanilir
             * StringBuilder'ın, string metodları kullanmaktan daha verimli olduğu anlamına gelir ve özellikle bellek kullanımı açısından avantajlıdır
             * StringBuilder, değiştirilebilir (mutable) bir yapıya sahiptir ve bir dizi metin operasyonu gerçekleştirmek için mevcut bir nesneyi değiştirir, böylece 
             * her operasyon için yeni bir string oluşturmak zorunda kalmaz. Bu, özellikle döngüler veya çok sayıda metin manipülasyonu içeren durumlarda bellek tasarrufu sağlar. */
            StringBuilder newString = new StringBuilder("StringBuilderin sonuna 6 tane S ekle ");// ici bos olan bir string olusturdum eger icine bir seyler yazmak istersem parantezin icine cift tirnak icinde yazdirabilirim 
            StringBuilder newString2 = new StringBuilder();
            StringBuilder anotherString = new StringBuilder("Merhaba Ben Yusuf Er");

            // Metotlar
            newString.Append('S', 6); // burada append metotu stringin en sonuna ekler.tek tirnak icinde char veri tipinde tek harf ekledim virgul koydum ve kac tane olmasini istiyorsam rakam yaziyorum burada ben 6 tane S eklemek istedim.
            newString2.Append('-', 6); // simdi 6 tane - ekliyorum 
            newString2.Append(" This is a StringBuilder ");// daha sonra bu yazilanlari ekliyorum
            newString2.Append('-', 6); // yazilanlarin sonuna 6 tane daha - ekliyorum
            newString2.Append("and this is the end of StringBuilder"); // ve son olarak en sona bu cumleyi ekliyorum
            newString2.Replace("and this is the end of StringBuilder", "my last replace");//Replace metotunu kullanip nereyi degistirmek istiyorsam orada yazani cift tirnak icinde yazip daha sonra virgul ekleyip yerine yazmak istedigimi cift tirnak icinde yaziyorum
            newString2.Remove(0, 30);// Remove metodunun icine nerden nereye kadarini silmek istiyorsam index numarasina gore onu yaziyorum.Burada ben 0.indexten 30.indexe kadar olan seyleri sildim
            newString2.Insert(0, "Insert metodu kullanildi burada ");// remove ile sildigim yerlerin yerine eklemek istedigimi yaziyorum insert metodu ile 


            anotherString.Append(" I am 26 years old ").AppendLine().Append("I am studying Business Information Technology"); /* anothersTring adli stringbuilderin sonuna append ile 26 yasimda oldugumu belirttim.Daha sonra appendLine ile asagi satira gectim
                                                                                                                               * ve tekrar append yazip en sona yazacaklarimi ekledim 
           
                                                                                                                               */

            











            //Console.Write(newString.ToString()); // stringbuilderi consola yazdirmak icin once stringbuilderin ismini sonra nokta koyup ToString() yaziyorum
            Console.WriteLine(newString2.ToString());
            Console.WriteLine(anotherString.ToString());




        }
    }
}
