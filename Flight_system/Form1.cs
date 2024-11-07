namespace Flight_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("From: " + comboBox1.Text + " to " + comboBox2.Text + "Date: " + dateTimePicker1.Text + "Time: " + maskedTextBox1.Text);
            listBox1.Items.Add("Passanger informations: Full Name " + textBox1.Text + "Passport number " + maskedTextBox2.Text + "Phone Number :" + maskedTextBox3.Text);
            MessageBox.Show("Your Ticket reservation has been made !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;


        }
    }
}
