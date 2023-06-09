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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
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
                MessageBox.Show("This user is not found");
            }
            else
            {
                textBox1.Text = (string)reader.GetValue(1).ToString();
                textBox2.Text = (string)reader.GetValue(0).ToString();
                textBox3.Text = (string)reader.GetValue(2).ToString();
                textBox4.Text = (string)reader.GetValue(3).ToString();
                textBox5.Text = (string)reader.GetValue(4).ToString();
                textBox6.Text = (string)reader.GetValue(5).ToString();
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RP47MRF;Initial Catalog=Libarary;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "INSERT INTO comment VALUES ('" + textBox7.Text + "' , '" + textBox8.Text + "' , '" + textBox2.Text + "' ) ";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The comment is added successfully.");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RP47MRF;Initial Catalog=Libarary;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "INSERT INTO Cart VALUES ('" + textBox3.Text + "' , '" + textBox1.Text + "' , '" + textBox2.Text + "' ) ";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The book is added to cart successfully.");
        }
    }
}
