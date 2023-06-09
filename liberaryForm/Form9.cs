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
    public partial class Form9 : Form
    {
        public Form9()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
