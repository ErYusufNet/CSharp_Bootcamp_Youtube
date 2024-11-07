namespace udemy_projeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have pressed the button");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Yusuf"
;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Enes";
            label7.Text = "Demir";
            label8.Text = "Muhendis";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yazilim muhendisligi";
            label9.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label10.Text = textBox2.Text;
            label11.Text = textBox3.Text;
            label12.Text = textBox4.Text;
        }
    }
}
