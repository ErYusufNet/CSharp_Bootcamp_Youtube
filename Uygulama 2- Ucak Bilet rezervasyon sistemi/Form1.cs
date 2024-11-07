namespace Uygulama_2__Ucak_Bilet_rezervasyon_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("From : " + comboBox1.Text + " to " + comboBox2.Text + " Date: " + dateTimePicker1.Text + " Time: " + maskedTextBox1.Text);
            listBox1.Items.Add("Passanger Informations :  Full name: " + textBox1.Text + " Passport Number :" + maskedTextBox2.Text + " Phone Number :" + maskedTextBox3.Text);
            MessageBox.Show("Your ticket reservation has been made");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
