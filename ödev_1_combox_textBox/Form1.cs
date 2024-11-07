namespace ödev_1_combox_textBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Information.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
        }
    }
}
