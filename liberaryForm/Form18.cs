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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RP47MRF;Initial Catalog=Libarary;Integrated Security=True");
        private void load_data()
        {
            SqlCommand cmd = new SqlCommand("SELECT BookID,BookName,price,CategoryName FROM book_ WHERE CategoryName= 'magazines'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
        }
        private void Form18_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
