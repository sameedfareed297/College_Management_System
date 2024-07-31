using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void label_XI_Click(object sender, EventArgs e)
        {

        }

        private void Dashbord_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // staff button
            using(StaffData sf = new StaffData())
            {
                sf.ShowDialog();
            }

        }

        private void btn_dash_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            using (student_RegistrstionForm std = new student_RegistrstionForm())
            {
                std.ShowDialog();
                
            }
        
            
           
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            using (fields_courses fc = new fields_courses())
            {
                fc.ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (fields_courses fc = new fields_courses())
            {
                fc.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (new_addmission new_add = new new_addmission())
            {
                new_add.ShowDialog();
            }
        }

        private void pictureBox_adm_Click(object sender, EventArgs e)
        {
            using (new_addmission new_add = new new_addmission())
            {
                new_add.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (fee_structure fee = new fee_structure())
            {
                fee.ShowDialog();
            }
        }

        private void pictureBox_staff_Click(object sender, EventArgs e)
        {
            using (StaffData sf = new StaffData())
            {
                sf.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //college rules button
            using (CollegeRules cr = new CollegeRules())
            {
                cr.ShowDialog();
            }
        }

        private void pictureBox_rules_Click(object sender, EventArgs e)
        {//college rules pic
            using (CollegeRules cr = new CollegeRules())
            {
                cr.ShowDialog();
            }
        }

        private void btn_contct_Click(object sender, EventArgs e)
        {
            using(aboutus a = new aboutus())
            {
                a.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (aboutus a = new aboutus())
            {
                a.ShowDialog();
            }
        }
    }
}
