using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment4._2
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            btnDel.Visible = false;
            Data.TopStudent();
            gridStudentList.AllowUserToResizeColumns = false;
            gridStudentList.AllowUserToResizeRows = false;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            gridStudentList.DataSource = Data.students;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //Id validating
            if (!int.TryParse(txtID.Text, out int value) || value <= 0)
            {
                MessageBox.Show("ID field should only contain positive numbers");
                return;
            }
            else
            {
                foreach (var s in Data.students)
                {
                    if (s.studentID == int.Parse(txtID.Text))
                    {
                        MessageBox.Show("Student ID already exists. Please enter a different number.");
                        return;
                    }
                }
            }
            //name validating
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter a name");
                return;
            }
            else
            {
                char[] c = (txtName.Text).ToCharArray();
                foreach (char ch in c)
                {
                    if (!char.IsLetter(ch))
                    {
                        MessageBox.Show("Name field should only contain letters");
                        break;
                    }
                }
            }

            //GPA validating
            if (!float.TryParse(txtGPA.Text, out float value2) || value2 < 0 || value2 > 4)
            {
                MessageBox.Show("Please enter a valid GPA");
                return;
            }

            Student student = new Student();
            student.studentID = int.Parse(txtID.Text);
            student.studentName = txtName.Text;
            student.GPA = (float)Math.Round(float.Parse(txtGPA.Text), 1);
            student.Email = student.emailGenerator(student.studentName);
            Data.students.Add(student);
            MessageBox.Show("Student added successfully");
            gridStudentList.DataSource = null;
            gridStudentList.DataSource = Data.students;
            Data.TopStudent();
        }

        private void gridStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //get the delete button to show next to the clicked row
            if (e.RowIndex < 0)
            {
                btnDel.Visible = false;
                return;
            }
            else

            {
                btnDel.Left = gridStudentList.Right - 85;
                btnDel.Top = gridStudentList.Top + (e.RowIndex + 1) * 29;
                btnDel.Visible = true;
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this student?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (gridStudentList.CurrentRow.Index == gridStudentList.Rows.Count - 1)
                {
                    gridStudentList_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
                }
                Data.students.RemoveAt(gridStudentList.CurrentRow.Index);
                gridStudentList.DataSource = null;
                gridStudentList.DataSource = Data.students;

                if (gridStudentList.Rows.Count == 0)
                {
                    btnDel.Visible = false;
                }
            }
            Data.TopStudent();

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}

