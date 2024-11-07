using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace udemy_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            car Volkswagen  = new car();
            Volkswagen.brand = "Golf";
            Volkswagen.price = 7000;
            Volkswagen.model = 2024;
            Volkswagen.color = "Blue";
            Volkswagen.speed = 2;

            label1.Text = Volkswagen.color;
            label2.Text = Volkswagen.speed.ToString();
            label3.Text = Volkswagen.price.ToString();
            label4.Text = Volkswagen.model.ToString();
            label5.Text = Volkswagen.brand.ToString();
            



        }
    }
}
