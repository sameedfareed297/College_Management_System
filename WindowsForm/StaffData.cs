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
    public partial class StaffData : Form
    {
        public StaffData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void StaffData_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;uid=root;pwd=test123456;database=teacherInfo";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select teacherdetails.Id as Teacher_ID,teacherdetails.TeacherName as TeacherName,teacherdetails.Email_Id as EmailId,teacherdetails.DepartmentName as Department,teacherdetails.Qualification as Qualification,teacherdetails.MobileNo as MobileNo,teacherdetails.gender as Gender,teacherdetails.class as Class from teacherdetails";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView_staff.DataSource = ds.Tables[0];
        }
    }
}
