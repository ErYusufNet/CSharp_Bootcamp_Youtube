namespace Uygulama_3_Sinema
{
    public partial class CinemaMarket : Form
    {
        public CinemaMarket()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            kasatutar += 5;
            Ciro2.Text = kasatutar.ToString();

            int popcorn, ticket, water, cola, total;
            popcorn = Convert.ToInt16(Popcorn.Text);
            ticket = Convert.ToInt16(Ticket.Text);
            water = Convert.ToInt16(Water.Text);
            cola = Convert.ToInt16(Cola.Text);
            total = popcorn * 5 + ticket * 15 + water    * 2 + cola * 4;
            price.Text = total.ToString();

        }
    }
}
