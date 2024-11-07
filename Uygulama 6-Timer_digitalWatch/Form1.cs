namespace Uygulama_6_Timer_digitalWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hour = 0, minute = 0, second = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            label1.Text = second.ToString();
            if(second==60)
            {
                minute++;
                label2.Text = minute.ToString();
                second = 0;
                if(minute==5)
                {
                    hour++;
                    label3.Text = hour.ToString();

                    minute = 0;
                }
            }

        }
    }
}
