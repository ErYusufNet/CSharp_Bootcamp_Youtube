namespace _12_encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            araba myCar = new araba();
            myCar.color = "Blue";
            myCar.price = 65000;
            myCar.speed = 260;
            myCar.engine = 1.6;
            myCar.NewOrSecondHand = 'N';
        }
    }
}
