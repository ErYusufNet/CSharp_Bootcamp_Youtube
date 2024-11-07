namespace udemy_data_types_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surname;
            int exam1, exam2, project;
            double avr;
            name = textBox1.Text;
            surname = textBox2.Text;
            exam1 = Convert.ToInt32(textBox3.Text);
            exam2 = Convert.ToInt32(textBox4.Text);
            project = Convert.ToInt32(textBox5.Text);
            avr = (exam1 + exam2 + project) / 3;
            listBox1.Items.Add(name + " " + surname + " final " +avr);

           
        }
    }
}
