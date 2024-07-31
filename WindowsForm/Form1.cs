using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        // Define a structure for a student
        struct Student
        {
            public string username;
            public string password;
        }

        // Define a node for a linked list
        class Node
        {
            public Student data;
            public Node next;
        }

        // Define a class for managing the linked list
        class StudentList
        {
            private Node head;

            // Function to add a student to the linked list
            public void AddStudent(Student student)
            {
                Node newNode = new Node { data = student, next = null };
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = newNode;
                }
            }

            // Function to search for a student in the linked list
            public bool SearchStudent(string username, string password)
            {
                Node current = head;
                while (current != null)
                {
                    if (current.data.username == username && current.data.password == password)
                    {
                        return true; // Student found
                    }
                    current = current.next;
                }
                return false; // Student not found
            }

            // Add more linked list operations as needed
        }

        private StudentList studentList;

        public Form1()
        {
            InitializeComponent();
            InitializeStudentList();
        }

        private void InitializeStudentList()
        {
            studentList = new StudentList();
            // Add some sample students to the linked list
            studentList.AddStudent(new Student { username = "student1", password = "pass1" });
            studentList.AddStudent(new Student { username = "student2", password = "pass2" });
            studentList.AddStudent(new Student { username = "student3", password = "pass3" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            if (studentList.SearchStudent(username, password))
            {
                MessageBox.Show("Login successful!");
                // Add code to open the dashboard window (not implemented in this example)
                Dashbord dashbord1 = new Dashbord();
                dashbord1.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password", "Sorry");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

