using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_Class2_exercise
{
    public class Car
    {
        public int doorNo;
        public string Model;
        public string Color;

        public void OpenDoors()
        {
            Console.WriteLine("Doors are opened!");
        }
        public void LockDoors()
        {
            Console.WriteLine("Doors are locked!");
        }
    }



}
