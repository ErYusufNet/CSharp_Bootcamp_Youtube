namespace udemy_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            if (counter == 10)
            {

                this.BackColor = Color.Pink;
            }
            if (counter == 20)
            {
                this.BackColor = Color.Magenta;
            }
            if (counter == 30)
            {
                this.BackColor = Color.Yellow;
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 75;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
        }
    }
}
