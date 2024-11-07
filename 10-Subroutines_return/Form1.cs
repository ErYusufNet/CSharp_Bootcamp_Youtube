namespace _10_Subroutines_return
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int total(int n1, int n2)
        {
            int n3 = n1 + n2;
            return n3;
        }
        int maths(int no1)
        {
            int result = no1 * no1 * no1;
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = total(4,6).ToString();   
            int s = Convert.ToInt32(textBox1.Text);
            label1.Text = maths(s).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
