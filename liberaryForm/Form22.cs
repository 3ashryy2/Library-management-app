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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RP47MRF;Initial Catalog=Libarary;Integrated Security=True");
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            con.Open();
            sqlcmd.CommandText = "Select Name, UserID from author where UserID not in (select UserID from book_)";
            sqlcmd.ExecuteNonQuery();
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
           dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
