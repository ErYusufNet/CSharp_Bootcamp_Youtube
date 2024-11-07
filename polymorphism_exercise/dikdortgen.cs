using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_exercise
{
    public class dikdortgen:shape
    {
        public int kisakenar { get; set; }
        public int uzunkenar { get; set; }
        public dikdortgen(string name,int _kisakenar,int _uzunkenar) : base(name)
        {
            this.name= name;
            this.kisakenar= _kisakenar;
            this.uzunkenar= _uzunkenar;

        }
        public override void shapeCount()
        {
            base.shapeCount();
        }
    }
}
