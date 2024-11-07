using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Encapsulation
{
    public class ogrenci
    {
        public string isim;
        public void setIsim(string _isim)
        {
            isim = _isim;
        }
        public string getIsim()
        {
            return isim;  
        }
    }
}
