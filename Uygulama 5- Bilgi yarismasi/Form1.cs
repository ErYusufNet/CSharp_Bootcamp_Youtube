namespace Uygulama_5__Bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int questionNumber = 0, trueAnsw = 0, falseAnsw = 0;

        private void Next_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            Next.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            

            questionNumber++;
            QNo.Text = questionNumber.ToString();

            if (questionNumber == 1)
            {
                richTextBox1.Text = "What is the capital city of France?";
                BtnA.Text = "London";
                BtnB.Text = "Paris";
                BtnC.Text = "Helsinki";
                BtnD.Text = "Miami";
                label4.Text = "Paris";
            }
            if (questionNumber == 2)

            {
                richTextBox1.Text = "What is the capital city of Finland?";
                BtnA.Text = "Tampere";
                BtnB.Text = "Oulu";
                BtnC.Text = "Lahti";
                BtnD.Text = "Helsinki";
                label4.Text = "Helsinki";


            }
            if (questionNumber == 3)
            {
                richTextBox1.Text = "What is the capital city of England?";
                BtnA.Text = "Liverpool";
                BtnB.Text = "Birmingham";
                BtnC.Text = "London";
                BtnD.Text = "Manchester";
                label4.Text = "London";
            }
            if(questionNumber == 4)
            {
                BtnA.Enabled= false;
                BtnB.Enabled= false;
                BtnC.Enabled= false;
                BtnD.Enabled= false;
                Next.Enabled= false;
                MessageBox.Show("True :" + trueAnsw + " "  + "False :" + falseAnsw);
            }

        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Next.Enabled = true;
            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                trueAnsw++;
                Tr.Text = trueAnsw.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falseAnsw++;
                Fl.Text = falseAnsw.ToString();
                pictureBox2.Visible = true;
            }


        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Next.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                trueAnsw++;
                Tr.Text = trueAnsw.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falseAnsw++;
                Fl.Text = falseAnsw.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Next.Enabled = true;
            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                trueAnsw++;
                Tr.Text = trueAnsw.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falseAnsw++;
                Fl.Text = falseAnsw.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Next.Enabled = true;

            label5.Text = BtnD.Text;
            if(label4.Text == label5.Text)
            {
                trueAnsw++;
                Tr.Text =trueAnsw.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falseAnsw++;
                Fl.Text = falseAnsw.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
