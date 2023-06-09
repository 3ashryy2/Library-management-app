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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
