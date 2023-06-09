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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RP47MRF;Initial Catalog=Libarary;Integrated Security=True");
          
            
            con.Open();
            string name = textBox1.Text;
            string email = textBox3.Text;
            string password = textBox2.Text;
            string id = textBox4.Text;
            string query = "UPDATE admin SET Name = '" + name + "' ,  Password = '" + password + "' ,Email = '" + email + "' WHERE UserID = " + id;
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The information is updated successfully");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RP47MRF;Initial Catalog=Libarary;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Select * from admin where UserID = '"+textBox4.Text+"'";
            SqlDataReader reader ;
           reader = cmd.ExecuteReader();
            if (reader.Read() == false)
            {
                MessageBox.Show("This user is not found");
            }
            else
            {
                textBox1.Text = (string)reader.GetValue(0).ToString();
                textBox2.Text = (string)reader.GetValue(1).ToString();
                textBox3.Text = (string)reader.GetValue(2).ToString();
                textBox4.Text = (string)reader.GetValue(3).ToString();
            }
            con.Close();
        }
    }
}
