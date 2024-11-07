namespace Udemy_foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] students = { "John", "Jimmy", "Yusuf" };
            foreach (string s in students)
            {
                listBox1.Items.Add(s);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 0;
            int[] points = { 70, 65, 85, 100, 90 };
            foreach(int x in points)
            {
                listBox2.Items.Add(x);
                total = total + x;
            }
            label1.Text = total.ToString();

            int avr = total / points.Length;
            label2.Text = avr.ToString();
        }
    }
}
