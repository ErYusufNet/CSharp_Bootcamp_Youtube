using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_interface
{
    public class customer : ICustomer
    {
        public void customerAdd()
        {
            Console.WriteLine("Customer added");
        }

        public void customerDelete()
        {
            Console.WriteLine("Customer deleted");
        }

        public void customerRemove()
        {
            Console.WriteLine("Customer removed");
        }

        public void customerUpdate()
        {
            Console.WriteLine("Customer updated");
        }
    }
}
