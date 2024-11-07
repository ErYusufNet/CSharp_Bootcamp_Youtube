namespace udemy_arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* string[] students = {"John","Jimmy","Mike"};
             label1.Text = students[0];*/
            /*int[]numbers = {1,2,3,4,5,6,7};
            label1.Text = numbers[2].ToString();*/

            /*string[] citys = { "Paris", "Helsinki", "London", "Miami" };
            for(int i = 0; i< citys.Length; i++)
            {
                listBox1.Items.Add(citys[i]);
            }*/
            /*int[]numbers = { 1, 2, 3, 4, 5, 6 };
            for(int i = 0; i < numbers.Length; i++)
            {
                listBox1.Items.Add(numbers[i]);
            }*/
            int[] numbers = {1,3,5,6,2,4,8,10,11};
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    listBox1.Items.Add(numbers[i]);
                }
            }



        }
    }
}
