namespace _2_Combox_listBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Oulu");
            comboBox1.Items.Add("Kotka");
            comboBox1.Items.Add("Kouvala");
            comboBox1.Items.Add("Rovaniemi");
            comboBox1.Items.Add("Kemi");
            comboBox1.Items.Add("Seinajoki");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);// add to combox1 , what is written in textbox1
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Miami");
            listBox1.Items.Add("Oslo");
            listBox1.Items.Add("Madrid");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Futbolcu");
            comboBox2.Items.Add("Kaynakci");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox3.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Add("Ingiltere");
            comboBox3.Items.Add("Finlandiya");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Add(textBox4.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            comboBox5.Items.Add("Rusya");
            comboBox5.Items.Add("Arjantin");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            comboBox5.Items.Add(textBox5.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            comboBox6.Items.Add("Ispanya");
            comboBox6.Items.Add("Almanya");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            comboBox6.Items.Add(textBox6.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
