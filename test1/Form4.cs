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

namespace test1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            using (IDbConnection connection = new SqlConnection())
            {

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            using (Test11Entities2 db = new Test11Entities2())
            {
                var Name = textBox1.Text;
                var Familia = textBox5.Text;
                var Otchestvo = textBox4.Text;
                var DateOfDitdhday = dateTimePicker1.Value;
                var Adress = textBox2.Text;
               

                List<Pachienti> pachientis = new List<Pachienti>();
                pachientis.Add(new Pachienti { Name =Name, Familia = Familia, Otchestvo = Otchestvo, DateOfBirthday = DateOfDitdhday, Adress = Adress });

                db.Pachienti.AddRange(pachientis);
                db.SaveChanges();

                MessageBox.Show("Данные сохранены");

                this.Hide();
                Form5 m = new Form5();
                m.Show();



            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 k = new Form5();
            k.Show();
        }
    }
}
