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
    public partial class Package : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TASRIF1532\SQLEXPRESS;Initial Catalog=DBreg;Integrated Security=True");
        public Package()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into packagetable values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox5.Text + "','" + comboBox4.Text + "','" +dateTimePicker1.Text+ "','" + comboBox6.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Insert record successfully");
            
            this.Hide();
            payment p = new payment();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from packagetable where locationid = '" + comboBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Insert DELETE successfully");
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
