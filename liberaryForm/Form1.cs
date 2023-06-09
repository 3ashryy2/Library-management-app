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

namespace liberaryForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RP47MRF;Initial Catalog=Libarary;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            cmd.Connection = con;
            cmd2.Connection = con;
            cmd.CommandText = "INSERT INTO userr VALUES ('" + textBox4.Text + "') ";
            cmd2.CommandText = "INSERT INTO admin VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' , '" + textBox4.Text + "') ";
            try 
            {
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The admin added successfully.");
            }
            catch(SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("This admin ID is already exist.");

                }
                

            }
            


            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RP47MRF;Initial Catalog=Libarary;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            cmd.Connection = con;
            cmd2.Connection = con;
            cmd.CommandText = "INSERT INTO userr VALUES ('" + textBox4.Text + "') ";
            cmd2.CommandText = "INSERT INTO Author VALUES ('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "' , '" + textBox4.Text + "') ";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The Author added successfully.");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("This Author ID is already exist.");

                }


            }
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RP47MRF;Initial Catalog=Libarary;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            cmd.Connection = con;
            cmd2.Connection = con;
            cmd.CommandText = "INSERT INTO userr VALUES ('" + textBox4.Text + "') ";
            cmd2.CommandText = "INSERT INTO Customer VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' , '" + textBox4.Text + "') ";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The Customer added successfully.");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("This Customer ID is already exist.");

                }
            }
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();

        }
    }
}
