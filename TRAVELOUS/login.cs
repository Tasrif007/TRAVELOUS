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

namespace TRAVELOUS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Package secoundlink = new Package();
            secoundlink.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regform secoundlink = new Regform();
            secoundlink.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=TASRIF1532\SQLEXPRESS;Initial Catalog=DDD;Integrated Security=True");
            string query = "Select count(*) from abc where username ='" + textBox1.Text.Trim() +
                "' and password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                dashboard linkup = new dashboard();
                linkup.Show();

            }
            else
            {
                MessageBox.Show("Please check ID and Password");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
            
    }
}
