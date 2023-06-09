using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liberaryForm
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form16 = new Form16();
            form16.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form14 = new Form14();
            form14.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form17 = new Form17();
            form17.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form18 = new Form18();
            form18.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form19 = new Form19();
            form19.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form20 = new Form20();
            form20.Show();
            this.Hide();
        }
    }
}
