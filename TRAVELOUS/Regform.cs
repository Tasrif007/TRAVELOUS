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
    public partial class Regform : Form
    {
         string connectionString = @"Data Source=TASRIF1532\SQLEXPRESS;Initial Catalog=DBreg;Integrated Security=True;";
         SqlConnection con = new SqlConnection(@"Data Source=TASRIF1532\SQLEXPRESS;Initial Catalog=DBreg;Integrated Security=True");
        
        public Regform()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
       {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (txtPassword.Text != txtConfirmPassword.Text)
                MessageBox.Show("Password do not match");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@First_Name", txtFirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Last_Name", txtLastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Confirm_Password", txtConfirmPassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is successfull");
                    this.Hide();
                    Package se = new Package();
                    se.Show();
                    Clear();

                }
            }
        }
        void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtContact.Text = txtAddress.Text = txtUsername.Text = txtPassword.Text =txtConfirmPassword.Text= "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update regtable set Address= '" + txtAddress + "' where First_Name='" + txtFirstName + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("UPDATE successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }


       
    }
}
