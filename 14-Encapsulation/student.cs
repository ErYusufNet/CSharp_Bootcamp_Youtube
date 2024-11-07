using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Encapsulation
{
    public class student
    {
        private string name;
        private int age ;

        public void setName(string _name)//setname ile private name kismina parametreden gelen degeri atiyorum
        {
            name = _name;
        }

        public string getName()
        {
            return name;
        }

        public void setAge(int _age)
        {
            age = _age;

        }
        public int getAge()
        {
            return age;
        }
       
    }

    
}
