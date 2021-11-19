using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_DB.business;
using Student_DB.dataAcess;
using Student_DB.Properties;
using Student_DB.Validations;
using System.Windows.Forms;


namespace Student_DB.GUI
{
    public partial class form_student : Form
    {
        List<Student> listc = new List<Student>();
        public form_student()
        {
            InitializeComponent();
            buttonList.Enabled = false;
        }


        private void textBoxStudentid_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_student_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure that you want to leave?",
                "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxStudentid.Clear();
            textBoxName.Clear();
            textBoxCours.Clear();
            textBoxFee.Clear();
            textBoxStudentid.Focus();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Stusentid = Convert.ToInt32(textBoxStudentid.Text);
            student.Name = textBoxName.Text;
            student.Cours = textBoxCours.Text;
            student.Fee = Convert.ToInt32(textBoxFee.Text);
            listc.Add(student);
            buttonList.Enabled = true;
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {

            List<Student> listc = StudentIO.ListStudent();
            if(Validetes.IsUnique(listc, Convert.ToInt32(textBoxStudentid.Text))
                 && Validetes.IsValidID(textBoxStudentid.Text) &&
                 Validetes.IsvalidName(textBoxName )) { 
                
            Student student = new Student();
                student.Stusentid = Convert.ToInt32(textBoxStudentid.Text);
                
               
            student.Name = textBoxName.Text;
            student.Cours = textBoxCours.Text;
            student.Fee = Convert.ToInt32(textBoxFee.Text);
            StudentIO.SaveRecord(student);
                     
            }
           

        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            StudentIO.ListStudent(listView1);
        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            StudentIO.Delete(Convert.ToInt32(textBoxStudentid.Text));
            MessageBox.Show("Student data successfully Deleted");

        }

        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Stusentid = Convert.ToInt32(textBoxStudentid.Text);
            student.Name = textBoxName.Text;
            student.Cours = textBoxCours.Text;
            student.Fee = Convert.ToInt32(textBoxFee.Text);
            DialogResult answer = MessageBox.Show("do you want want realy to update the student data",
                "update student", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(answer == DialogResult.Yes)
            {
                StudentIO.UpDate(student);
                MessageBox.Show("Student Updaeted");
            }
                

        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = comboBoxSearch.SelectedIndex;
            switch (choice)
            {
                case 0:
                    labelsearchby.Text = "please enter the Student ID";
                    break;
                case 1:
                    labelsearchby.Text = "please enter the Student Name";
                    break;
                case 2:
                    labelsearchby.Text = "please enter the Student Cours";
                    break;
                default:
                    break;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int choice = comboBoxSearch.SelectedIndex;
            switch (choice)
            {
                case -1:
                    MessageBox.Show("Please enter one option");
                    break;
                case 0:
                    Student student = StudentIO.Search(Convert.ToInt32(textBoxinputinfo.Text));
                    if(student != null)
                    {
                        textBoxStudentid.Text = (student.Stusentid).ToString();
                        textBoxName.Text = student.Name;
                        textBoxCours.Text = student.Cours;
                        textBoxFee.Text = (student.Fee).ToString();

                    }
                    else
                    {
                        MessageBox.Show("Student not found");
                        textBoxinputinfo.Clear();
                        textBoxinputinfo.Focus();
                    }
                    textBoxinputinfo.Clear();
                    break;
                case 1:
                    Student studentt = StudentIO.Search(textBoxinputinfo.Text);
                    if (studentt != null)
                    {
                        textBoxStudentid.Text = (studentt.Stusentid).ToString();
                        textBoxName.Text = studentt.Name;
                        textBoxCours.Text = studentt.Cours;
                        textBoxFee.Text = (studentt.Fee).ToString();

                    }
                    else
                    {
                        MessageBox.Show("Student name not found");
                        textBoxinputinfo.Clear();
                        textBoxinputinfo.Focus();
                    }
                    textBoxinputinfo.Clear();
                    break;
               
                 
                default:
                    break;
            }
        }
    }
}
