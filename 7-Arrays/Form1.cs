namespace _7_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
              variable_type[]variable_name={""}

             */
            string[] students = { "Yusuf", "John", "Mike","Paul","Henry" };
            //label1.Text = students[1];

            // if we have int variable then its like this:
            int[] numbers = { 1, 2, 3, 4, 5, 6, };
            //label1.Text = numbers[5].ToString();

           /* string[] citys = { "Lahti", "Tampere", "Oulu", "Helsinki" };
            for(int i = 0; i < citys.Length; i++)
            {
                listBox1.Items.Add(citys[i]);
            }*/
           // how we can print only even numbers in array
            int[]numbers2= { 1, 2, 3,4, 5, 6, 7 };
            for (int i = 0; i < numbers2.Length; i++) 
            {
                if (numbers2[i]%2 == 0)
                {
                    listBox1.Items.Add(numbers2[i]);
                }
            }
        }
    }
}
