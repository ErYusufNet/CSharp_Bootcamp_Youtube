using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_interface
{
    public interface ICustomer
    {
        void customerAdd();// erisim belirleyicisine gerek yok // metotun icini doldurmaya gerek yok 
        void customerRemove();
        void customerUpdate();
        void customerDelete();

    }
}
