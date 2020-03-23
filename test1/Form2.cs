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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 n = new Form1();
            n.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using(Test11Entities2 db = new Test11Entities2())
            {
                var Login = textBox1.Text;
                var Pass = textBox2.Text;
                var Admins = db.admin.AsNoTracking().FirstOrDefault(u => u.Name == Login && u.Password == Pass);
              
                if (Admins == null)
                {
                    MessageBox.Show("Введен неверный логин или пароль");
                    return;
                }

                else
                {
                    MessageBox.Show("Добро Поржаловать");

                    this.Hide();
                    Form5 k = new Form5();
                    k.Show();
                }

            }
            }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 gh = new Form4();
            gh.Show();
        }
    }
    }

