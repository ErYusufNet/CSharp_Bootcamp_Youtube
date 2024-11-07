namespace _8_Foreach_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] students = { "John", "Jimmy", "Petri" };
            foreach(string student in students)
            {
                listBox1.Items.Add(student);
            }
        }
    }
}
