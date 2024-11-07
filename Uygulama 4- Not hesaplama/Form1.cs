namespace Uygulama_4__Not_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, proje, ort;
            string durum;
            s1 = double.Parse(textBox1.Text);
            s2 = double.Parse(textBox2.Text);
            proje = double.Parse(textBox3.Text);
            ort = (s1 + s2 + proje) / 3;
            if (ort >= 50)
            {
                durum = "gecti";
                
            }
            else
            {
                durum = "kaldi";
            }
            MessageBox.Show("Ogrencinin ortalamasi :" + ort + " ogrenci dersten " + durum);

        }
    }
}
