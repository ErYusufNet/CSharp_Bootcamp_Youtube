using System.Windows.Forms;

namespace salpaus_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Yusuf";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "Yusuf";
            label7.Text = "Er";
            label8.Text = "Salpaus";
            MessageBox.Show("Here is your informations");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here is your informations");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Miami");
            comboBox1.Items.Add("Lahti");
            comboBox1.Items.Add("Tampere");
            comboBox1.Items.Add(textBox1.Text);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
