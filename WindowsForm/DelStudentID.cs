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
    public partial class DelStudentID : Form
    {
        public DelStudentID()
        {
            InitializeComponent();
        }

        private void btn_delete_id_Click(object sender, EventArgs e)
        { 
            Int64 id = int.Parse(textBox_delt.Text);
            if (MessageBox.Show("This will delete your data", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK){

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost;uid=root;pwd=test123456;database=Student";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from newadmission where student_ID + " +textBox_delt.Text+ "";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Deletion Complete","Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void DelStudentID_Load(object sender, EventArgs e)
            
        {
            
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;uid=root;pwd=test123456;database=Student";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from newadmission";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView_table.DataSource = ds.Tables[0];
        }

        private void textBox_delt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close button
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
