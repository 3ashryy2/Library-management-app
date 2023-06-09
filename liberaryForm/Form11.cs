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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RP47MRF;Initial Catalog=Libarary;Integrated Security=True");
        private void load_data()
        {
            SqlCommand cmd = new SqlCommand("SELECT BookName,price FROM book_", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
        }


        private void Form11_Load(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
