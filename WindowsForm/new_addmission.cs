using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
namespace WindowsForm
{
    public partial class new_addmission : Form
    {
        public new_addmission()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_addm_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string fname = textBox_fname.Text;
            string gender = "";
            bool isChecked = radioButton_male.Checked;
            if (isChecked)
            {
                gender = radioButton_male.Text;
            }
            else
            {
                gender = radioButton_female.Text;
            }
            string dob = dateTimePicker_DOB.Text;
            Int64 mobile = Int64.Parse(textBox_mob.Text);
            Int64 session = Int64.Parse(textBox_session.Text);
            string f_occ = textBox_focc.Text;
            string field = txtfield_select.Text;
            Int64 ssc = Int64.Parse(textBox_ssc.Text);
            string address = textBox_area.Text;

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;uid=root;pwd=test123456;database=Student";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into newadmission(student_name,f_name,Gender,DOB,Mobile_No,Sessions,F_occupation,Field,SSC_Percentage,Address_area) values ('" + name + "', '" + fname + "', '" + gender + "','" + dob + "'," + mobile + "," + session + ",'" + f_occ + "','" + field + "'," + ssc + ",'" + address + "')";
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            if (textBox_name.Text == ""|| textBox_fname.Text == "" || textBox_focc.Text == "" || textBox_mob.Text == ""||textBox_session.Text == ""|| textBox_ssc.Text == "" || txtfield_select.Text == "" ||  textBox_area.Text == ""|| radioButton_male.Text == ""|| radioButton_male.Text == "") 
            {
                MessageBox.Show("Please complete all fields before submitting the form.", "Incomplete Fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Data saved", "THANK YOU", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            textBox_name.Clear();
            textBox_fname.Clear();
            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
            textBox_mob.Clear();
            textBox_session.Clear();
            textBox_focc.Clear();
            txtfield_select.ResetText();
            textBox_ssc.Clear();
            textBox_area.Clear();
        }
    }
}
