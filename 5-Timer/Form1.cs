namespace _5_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0; // first we set a counter second to 0

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            if (counter == 1)
            {

                this.BackColor = Color.Black;
            }
            if (counter == 10)
            {

                this.BackColor = Color.Red;
            }
            if (counter == 20)
            {
                this.BackColor = Color.Green;
            }
            if (counter == 30)
            {
                this.BackColor = Color.Blue;
                counter = 0;
            }
        }
    }
}
