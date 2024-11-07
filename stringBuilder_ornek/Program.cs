using System;
using System.Text;

public class Words
{
    private string word;

    // Constructor: Kelimeyi başlatmak için kullandim
    public Words(string initialWord)
    {
        word = initialWord;
    }

    // SetWord: Kelimeyi değiştirmek için kullanılır.Yani daha sonradan icini degistirecegim icin setword kullandim // set 
    public void SetWord(string newWord)
    {
        word = newWord;
    }

    // Count: Kelimenin karakter sayısını döndürür.
    public int Count()
    {
        return word.Length;
    }

    // Count: Belirtilen karakterin kelime içinde kaç kez geçtiğini döndürür.
    public int Count(char character)
    {
        // Karakterin kelime içinde kaç kez geçtiğini sayan bir sayacı başlatiyorum
        int count = 0;

        // Her bir karakteri kontrol et ve hedef karakterle eşleşenleri say.
        foreach (char c in word)
        {
            if (c == character)
            {
                count++;
            }
        }

        // Toplam sayıyı döndür.
        return count;
    }

    // Replace: Belirtilen eski karakteri yeni karakterle değiştirir ve kelimeyi döndürür.
    public string Replace(char oldChar, char newChar)
    {
        if (word.Contains(oldChar.ToString()))
        {
            // Eğer kelime, eski karakteri içeriyorsa, işleme devam et.

            // İlk indeksi ve son indeksi bul.
            int firstIndex = word.IndexOf(oldChar); // ilk indexi buluyorum
            int lastIndex = word.LastIndexOf(oldChar);// son indexi buluyorum

            // Eski karakterin ilk bulunduğu indeksi, yeni karakter ile değiştir.
            word = word.Remove(firstIndex, 1).Insert(firstIndex, newChar.ToString());// remove ile firstIndex 1. siliyorum sonra insert diyip yerine ekliyorum


            // Eski karakterin son bulunduğu indeksi, yeni karakter ile değiştir.
            word = word.Remove(lastIndex, 1).Insert(lastIndex, newChar.ToString());
        }

        return word;
    }

    // ToString: Kelimenin değerini döndürür.
    public override string ToString()
    {
        return word;
    }
}
