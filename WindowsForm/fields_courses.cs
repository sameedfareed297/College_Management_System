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
    public partial class fields_courses : Form
    {
        public fields_courses()
        {
            InitializeComponent();
        }

        private void btn_dash_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_comp_Click(object sender, EventArgs e)
        {
            using (CsCourse cs = new CsCourse())
            {
                cs.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // PRE ENG
            using(PreEng preEng= new PreEng()) { 
                preEng.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // COMMERCE
            using(ComCourses com = new ComCourses())
            {
                com.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // PRE MED
            using(PRE_MED premed = new PRE_MED())
            {
                premed.ShowDialog();
            }
        }
    }
}
