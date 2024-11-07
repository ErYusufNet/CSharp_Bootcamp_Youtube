using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace requirtments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=YusufEr\\SQLEXPRESS;Initial Catalog=requirtment;Integrated Security=True;");




        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'requirtmentDataSet20.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.requirtmentDataSet20.users);
            // TODO: This line of code loads data into the 'requirtmentDataSet19.user_roles' table. You can move, or remove it, as needed.
            this.user_rolesTableAdapter.Fill(this.requirtmentDataSet19.user_roles);
            // TODO: This line of code loads data into the 'requirtmentDataSet18.requirtements_history' table. You can move, or remove it, as needed.
            this.requirtements_historyTableAdapter.Fill(this.requirtmentDataSet18.requirtements_history);
            // TODO: This line of code loads data into the 'requirtmentDataSet17.requirtements' table. You can move, or remove it, as needed.
            this.requirtementsTableAdapter.Fill(this.requirtmentDataSet17.requirtements);
            // TODO: This line of code loads data into the 'requirtmentDataSet15.requirment_dependencies' table. You can move, or remove it, as needed.
            this.requirment_dependenciesTableAdapter.Fill(this.requirtmentDataSet15.requirment_dependencies);
            // TODO: This line of code loads data into the 'requirtmentDataSet12.projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter1.Fill(this.requirtmentDataSet12.projects);
            // TODO: This line of code loads data into the 'requirtmentDataSet11.comments' table. You can move, or remove it, as needed.
            this.commentsTableAdapter.Fill(this.requirtmentDataSet11.comments);
            // TODO: This line of code loads data into the 'requirtmentDataSet10.comment_requirtements' table. You can move, or remove it, as needed.
            this.comment_requirtementsTableAdapter1.Fill(this.requirtmentDataSet10.comment_requirtements);
            // TODO: This line of code loads data into the 'requirtmentDataSet9.comment_projects' table. You can move, or remove it, as needed.
            this.comment_projectsTableAdapter3.Fill(this.requirtmentDataSet9.comment_projects);
            // TODO: This line of code loads data into the 'requirtmentDataSet7.comment_projects' table. You can move, or remove it, as needed.
            this.comment_projectsTableAdapter2.Fill(this.requirtmentDataSet7.comment_projects);
            // TODO: This line of code loads data into the 'requirtmentDataSet6.projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.requirtmentDataSet6.projects);
            // TODO: This line of code loads data into the 'requirtmentDataSet5.comment_projects' table. You can move, or remove it, as needed.
            this.comment_projectsTableAdapter1.Fill(this.requirtmentDataSet5.comment_projects);
            // TODO: This line of code loads data into the 'requirtmentDataSet.comment_requirtements' table. You can move, or remove it, as needed.
            this.comment_requirtementsTableAdapter.Fill(this.requirtmentDataSet.comment_requirtements);
            // TODO: This line of code loads data into the 'requirtmentDataSet2.comment_projects' table. You can move, or remove it, as needed.
            this.comment_projectsTableAdapter.Fill(this.requirtmentDataSet2.comment_projects);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.requirtements(requirtement_name, requirtement_description, requirtement_status, requirtement_version) VALUES (@p1, @p2, @p3, @p4)", connection);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            cmd.Parameters.AddWithValue("@p3", textBox3.Text);
            cmd.Parameters.AddWithValue("@p4", textBox4.Text);

            cmd.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Saved");
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
