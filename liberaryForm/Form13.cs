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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RP47MRF;Initial Catalog=Libarary;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Select * from book_ where BookName = '" + textBox1.Text + "'";
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read() == false)
            {
                MessageBox.Show("This book is not found");
            }
            else
            {
                textBox1.Text = (string)reader.GetValue(1).ToString();
                textBox2.Text = (string)reader.GetValue(0).ToString();
                textBox3.Text = (string)reader.GetValue(2).ToString();
                
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RP47MRF;Initial Catalog=Libarary;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "INSERT INTO Basket VALUES ('" + textBox3.Text + "' , '" + textBox2.Text + "' , '" + textBox1.Text + "' ) ";
            cmd.ExecuteNonQuery();
            try
            {
                SqlCommand cmd2 = new SqlCommand("DELETE FROM [Cart] WHERE BookID = '" + textBox2.Text + "' ", con);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("you buy this book successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error has occured,please thy again.");
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RP47MRF;Initial Catalog=Libarary;Integrated Security=True");
            con.Open();
            try
            {
                SqlCommand cmd2 = new SqlCommand("DELETE FROM [Cart] WHERE BookID = '" + textBox2.Text + "' ", con);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("This book is removed from cart successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error has occured,please thy again.");
            }
            finally
            {
                con.Close();
            }
            

        }
    }
}
