namespace _11_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            car myCar = new car(); // from car class we create object(myCar)
            myCar.color = "Black";
            myCar.price = 3500;
            myCar.SoN = 'n';//new car
            myCar.engine = 2.5;
            myCar.speed = 180;

            label1.Text = myCar.color;
            label2.Text = myCar.price.ToString();
            label3.Text = myCar.SoN.ToString();
            label4.Text = myCar.engine.ToString();
            label5.Text = myCar.speed.ToString();
            pictureBox1.BackColor = Color.Black;


        }
    }
}
