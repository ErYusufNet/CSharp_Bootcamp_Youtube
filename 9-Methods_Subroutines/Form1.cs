namespace _9_Methods_Subroutines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void clean()// we define what our code going to do 
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
        private void color()
        {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.Red;
            textBox3.BackColor = Color.Black;
            textBox4.BackColor = Color.Blue;

        }
        private void write()
        {
            textBox1.Text = "Yusuf";
            textBox2.Text = "Er";
            textBox3.Text = "26";
            textBox4.Text = "Finland";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clean();// we write our definition's(metod/subroutine)name and it will do whats inside
        }

        private void button2_Click(object sender, EventArgs e)
        {
            color();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            write();
        }

        
    }
}
