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
    public partial class payment : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TASRIF1532\SQLEXPRESS;Initial Catalog=DBreg;Integrated Security=True");

        public payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into paymenttable values('" +textBox3.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Payment is successfull");
            this.Hide();
            Congratulation w = new Congratulation();
            w.Show();
        }
    }
}
