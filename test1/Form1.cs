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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using(IDbConnection connection = new  SqlConnection())
            {

            }
        }

    

        private void Button1_Click(object sender, EventArgs e)
        {
            using(Test11Entities2 db = new Test11Entities2())
            {
                var Login = textBox1.Text;
                var Pass1 = textBox2.Text;
                var Pass2 = textBox3.Text;
                if (Pass1 != Pass2)
                {
                    MessageBox.Show("Введите пароль еще раз");
                    return;
                }
                if (Pass1.Length < 4)
                {
                    MessageBox.Show("Пароль должен собержать 4 и более символов");
                    return;
                }
                var hasDigits = false;
                var hasUpperCase = false;
                var hasLowers = false;
                var specChars = "!@#$%^&*()_+";
                var hasSpecChars = false;
                for (var i =0; i< Pass1.Length; i++)
                {
                    var ch = Pass1[i];
                    if (Char.IsLower(ch)) hasLowers = true;
                    if (Char.IsUpper(ch)) hasUpperCase = true;
                    if (specChars.Contains(ch)) hasSpecChars = true;
                    if (Char.IsDigit(ch)) hasDigits = true;
                }
                if(!(hasUpperCase|| hasSpecChars || hasLowers || hasDigits))
                {
                    MessageBox.Show("Введите другой пароль");
                    return;
                }
                if (Login.Length == 0 || Pass1.Length == 0)
                {
                    MessageBox.Show("Введите логин и пароль");
                    return;
                }

                List<admin> admins = new List<admin>();
                admins.Add(new admin { Name = Login, Password = Pass1 });

                db.admin.AddRange(admins);
                db.SaveChanges();

                MessageBox.Show("Данные сохранены");

                this.Hide();
                Form2 m = new Form2();
                m.Show();



            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 m = new Form2();
            m.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }    
       
    }
}
