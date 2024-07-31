namespace WindowsForm
{
    partial class DelStudentID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_delt = new System.Windows.Forms.TextBox();
            this.btn_delete_id = new System.Windows.Forms.Button();
            this.dataGridView_table = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 52);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1224, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 675);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 675);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(262, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Student_ID";
            // 
            // textBox_delt
            // 
            this.textBox_delt.Location = new System.Drawing.Point(469, 75);
            this.textBox_delt.Multiline = true;
            this.textBox_delt.Name = "textBox_delt";
            this.textBox_delt.Size = new System.Drawing.Size(221, 32);
            this.textBox_delt.TabIndex = 6;
            this.textBox_delt.TextChanged += new System.EventHandler(this.textBox_delt_TextChanged);
            // 
            // btn_delete_id
            // 
            this.btn_delete_id.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_delete_id.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete_id.Location = new System.Drawing.Point(506, 134);
            this.btn_delete_id.Name = "btn_delete_id";
            this.btn_delete_id.Size = new System.Drawing.Size(146, 47);
            this.btn_delete_id.TabIndex = 7;
            this.btn_delete_id.Text = "Delete\r\n";
            this.btn_delete_id.UseVisualStyleBackColor = false;
            this.btn_delete_id.Click += new System.EventHandler(this.btn_delete_id_Click);
            // 
            // dataGridView_table
            // 
            this.dataGridView_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_table.Location = new System.Drawing.Point(26, 207);
            this.dataGridView_table.Name = "dataGridView_table";
            this.dataGridView_table.RowHeadersWidth = 51;
            this.dataGridView_table.RowTemplate.Height = 24;
            this.dataGridView_table.Size = new System.Drawing.Size(1165, 498);
            this.dataGridView_table.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsForm.Properties.Resources.removestuden;
            this.pictureBox1.Location = new System.Drawing.Point(794, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::WindowsForm.Properties.Resources.close_button3;
            this.button2.Location = new System.Drawing.Point(1165, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 43);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::WindowsForm.Properties.Resources.close_button3;
            this.button1.Location = new System.Drawing.Point(1406, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 52);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(330, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 94);
            this.label2.TabIndex = 19;
            this.label2.Text = "DELETE STUDENT RECORD\r\n\r\n";
            // 
            // DelStudentID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 727);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView_table);
            this.Controls.Add(this.btn_delete_id);
            this.Controls.Add(this.textBox_delt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DelStudentID";
            this.Text = "DelStudentID";
            this.Load += new System.EventHandler(this.DelStudentID_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_delt;
        private System.Windows.Forms.Button btn_delete_id;
        private System.Windows.Forms.DataGridView dataGridView_table;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}