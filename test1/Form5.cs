using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 n = new Form4();
            n.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 n = new Form2();
            n.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 n = new Form3();
            n.Show();
        }
    }
}
