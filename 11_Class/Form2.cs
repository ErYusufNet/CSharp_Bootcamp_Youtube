using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Class
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            car myCar2 = new car(); // from car class we create object(myCar)
            myCar2.color = "Black";
            myCar2.price = 3500;
            myCar2.SoN = 'n';//new car
            myCar2.engine = 2.5;
            myCar2.speed = 180;

            label1.Text = myCar2.color;
            label2.Text = myCar2.price.ToString();
            label3.Text = myCar2.SoN.ToString();
            label4.Text = myCar2.engine.ToString();
            label5.Text = myCar2.speed.ToString();
            pictureBox1.BackColor = Color.Black;
        }
    }
}
