using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class student_RegistrstionForm : Form
    {
        public student_RegistrstionForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btn_dash_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void student_RegistrstionForm_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;uid=root;pwd=test123456;database=Student";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select newadmission.student_id as Student_ID,newadmission.student_name as StudentName,newadmission.f_name as FatherName,newadmission.Gender as Gender,newadmission.DOB as Date_Of_Birth,newadmission.Mobile_No as MobileNo,newadmission.Sessions as Session,newadmission.F_occupation as FatherOccupation,newadmission.Field as Field,newadmission.SSC_Percentage as SSC_Percentage,newadmission.Address_area as Address_Area from newadmission" ;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using(new_addmission na = new new_addmission())
            {
                na.ShowDialog();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            using(DelStudentID del = new DelStudentID())
            {
                del.ShowDialog();
            }
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;uid=root;pwd=test123456;database=Student";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from newadmission where student_id";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
