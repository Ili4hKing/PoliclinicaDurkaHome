using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            using (IDbConnection connection = new SqlConnection())
            {

            }
            
            using (Test11Entities2 db = new Test11Entities2())
            {
                var pacients = db.Pachienti;
                var Doctors = db.Doctor;
                foreach (Pachienti pl in pacients)
                {

                    comboBox1.Items.Add(pl.Familia + " "+ pl.Name +" "+ pl.Otchestvo);

                }
                foreach (Doctor tl in Doctors)
                {

                    comboBox2.Items.Add(tl.FIO +", "+tl.Specialnost);
                    

                }




            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Test11Entities2 db = new Test11Entities2())
            {
               
                var Doctors = db.Doctor;
               
                foreach (Doctor tl in Doctors)
                {


                    int Iid = comboBox1.SelectedIndex + 1;

                    if (tl.id == Iid)
                    {

                        label6.Text = tl.Specialnost;


                    }




                }




            }




        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          


                
            }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 k = new Form5();
            k.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (Test11Entities2 db = new Test11Entities2())
            {
                var Doctor = comboBox2.Text;
                var Pachient = comboBox1.Text;
                var DatePriema = dateTimePicker1.Value;
                var Spechialnost = label6.Text;

                List<PriemPacientov> PriemPacientovs = new List<PriemPacientov>();
                PriemPacientovs.Add(new PriemPacientov {Doctor = Doctor, Pacient = Pachient, Date_of_priema = DatePriema, Specialnost = Spechialnost});

                db.PriemPacientov.AddRange(PriemPacientovs);
                db.SaveChanges();

                MessageBox.Show("Данные сохранены");

                this.Hide();
                Form5 m = new Form5();
                m.Show();



            }
        }
    }
    }
