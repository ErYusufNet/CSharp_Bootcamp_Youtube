using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Inheritance_protected
{   /*private olanlara erismek icin constructor kurup parametreleri onlara atiyoruz
     * daha sonra get set yapiyoruz
     * 
     */
    public class employee
    {
        private int id;
        private string name;
        private string surname;

        public employee(int _id, string _name,string _surname)
        {       
            this.id = _id;
            this.name = _name;
            this.surname = _surname;
                
        }
        public int getId()
        {
            return this.id; // private olan id ye erisim sagliyoruz
        }
        public void setId(int id)
        {
            this.id = id;// hem parametreye hem de icerdeki atamaya id yapiyoruz set icin
        }
        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public String getSurname()
        {
            return this.surname;
        }
        public void setSurname(string surname)
        {
            this.setSurname(surname);
        }

        public void displayInfo()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.name);
            Console.WriteLine(this.surname);

        }
    }
}
