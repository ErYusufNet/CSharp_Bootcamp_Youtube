using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salpaus_properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // auto implemented properties: shortcut when no additional logic is required in the property
            // you dont have to define a field for a property
            // you only have to write get set inside the property
            car car1 = new car("BMW");

        }

        class car
        {
            public string Model { get; set; }

            
            public car(string _model)
            {
                this.Model = _model;
            }
        }
    }
}
