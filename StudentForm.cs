using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            BindGrid();
            btnUpdate.Visible = false;
            btnAddNewStudent.Visible = false;
            panelWelcome.Visible = true;
            panelStudent.Visible = false;
            panelReport.Visible = false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            bool correct = true;

            Student student = new Student();


            if (txtFirstName.Text.Equals("") && txtLastName.Text.Equals("") && txtAddress.Text.Equals("") &&
            txtContactNo.Text.Equals("") && txtEmail.Text.Equals("") && cmbProgramEnrol.SelectedIndex == -1 &&
           cmbGender.SelectedIndex == -1 && cmbProgramEnrol.SelectedIndex == -1 && cmbEnrolmentStatus.SelectedIndex == -1)
            {
                // Configure message box
                string message = "Please Fill Enrolment Form.";
                string caption = "Enrolment Form Error !";
                // Show message box
                MessageBox.Show(message, caption);

                correct = false;
            }
            else
            {
                if (txtFirstName.Text.Equals("") && txtLastName.Text.Equals(""))
                {
                    // Configure message box
                    string message = "Enter First Name and Last Name.";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;


                }
                else
                {
                    student.Name = txtFirstName.Text + " " + txtLastName.Text;
                }

                if (txtAddress.Text.Equals(""))
                {
                    string message = "Enter Address.";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;
                }
                else
                {
                    student.Address = txtAddress.Text;

                }

                Regex validatorPhone = new Regex("^[9]{1}[0-9]{9}$");
                string matchPhone = validatorPhone.Match(txtContactNo.Text).Value.ToString();

                if (matchPhone.Length == 10)
                {
                    student.ContactNo = txtContactNo.Text;

                }
                else
                {
                    string message = "Enter Phone Number. [10 digit mobile number starting with 9]";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;
                }
                const string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                bool isValid = regex.IsMatch(txtEmail.Text);

                if (isValid == true)
                {
                    student.Email = txtEmail.Text;

                }
                else
                {
                    string message = "Enter Email Address. [abc@abc.abc format]";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;
                }

                if (cmbProgramEnrol.SelectedIndex == -1)
                {
                    string message = "Choose a Program.";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;
                }
                else
                {
                    student.ProgramEnrol = cmbProgramEnrol.SelectedItem.ToString();
                }

                if (cmbGender.SelectedIndex == -1)
                {
                    string message = "Choose a Gender.";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;
                }
                else
                {
                    student.Gender = cmbGender.SelectedItem.ToString();
                }
                if (cmbEnrolmentStatus.SelectedIndex == -1)
                {
                    string message = "Choose Enrolment Status.";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;
                }
                else
                {
                    student.EnrolmentStatus = cmbEnrolmentStatus.SelectedItem.ToString();
                }
                if (dTPRegistrationDate.Text.Contains("Saturday"))
                {
                    string message = "Enrolment Closed on Weekends.";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;
                }
                else
                {
                    student.RegistrationDate = dTPRegistrationDate.Value;
                }

                student.BirthDate = dTPBirthDate.Value;
            }

            if (correct == true)
            {
            
                student.Add(student);
                BindGrid();
                string message = "Student Record Sucessful Added.";
                string caption = "Enrolment Form";
                // Show message box
                MessageBox.Show(message, caption);
                Clear();
            }
     
        }
        private void BindGrid()
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listStudents);
            dataGridStudents.DataSource = dt;
            BindChart(listStudents);
            dataGridViewReport(listStudents);
        }
        private void Clear()
        {
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            dTPBirthDate.Value = DateTime.Today;
            txtContactNo.Text = "";
            cmbGender.SelectedItem = null;
            cmbProgramEnrol.SelectedItem = null;
            dTPRegistrationDate.Value = DateTime.Today;
            cmbEnrolmentStatus.SelectedItem = null;

        }
        //This is for grid click, which brings the id of student (not used)
        //private void GridRow_DbClick(object sender, DataGridViewRowEventArgs e)
        //{
        //    int id = 0;
        //    string myValue = dataGridStudents[e.Row.Index, 0].Value.ToString();

        //    //get the clicked id 
        //    //read text file 
        //    Student obj = new Student();
        //    List<Student> listStudents = obj.List();
        //    Student s = listStudents.Where(x => x.Id == id).FirstOrDefault();

        //}

        private void DataGridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Student obj = new Student();
            if (e.ColumnIndex == 0)
            {
                //get the value of the clicked rows id column
                string value = dataGridStudents[2, e.RowIndex].Value.ToString();
                int id = 0;
                if (String.IsNullOrEmpty(value))
                {
                    MessageBox.Show("Invalid Data");
                }
                else
                {
                    id = int.Parse(value);
                    Student s = obj.List().Where(x => x.Id == id).FirstOrDefault();
                    txtId.Text = s.Id.ToString();
                    txtFirstName.Text = s.Name.Split(' ')[0];
                    txtLastName.Text = s.Name.Split(' ')[1];
                    txtAddress.Text = s.Address;
                    txtEmail.Text = s.Email;
                    dTPBirthDate.Value = s.BirthDate;
                    txtContactNo.Text = s.ContactNo;
                    cmbGender.SelectedItem = s.Gender;
                    cmbProgramEnrol.SelectedItem = s.ProgramEnrol;
                    dTPRegistrationDate.Value = s.RegistrationDate;
                    cmbEnrolmentStatus.SelectedItem = s.EnrolmentStatus;
                    btnSubmit.Visible = false;
                    btnUpdate.Visible = true;
                    btnAddNewStudent.Visible = true;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                string message = "Do you want to Delete this Record?";
                string title = "Delete Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    //get the value of the clicked rows id column
                    string value = dataGridStudents[2, e.RowIndex].Value.ToString();
                    obj.Delete(int.Parse(value));
                    BindGrid();
                    MessageBox.Show("Student Record Successfully Deleted");
                }
            }
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Student updatedStudent = new Student();
            updatedStudent.Id = int.Parse(txtId.Text);

            /*initial value of correct is true, when any value from the form is empty or incorrect 
            then the value changed to false. Unless the value of correct is true, form values will not be added to Objstudent */ 
        
            bool correct = true;

            if (txtFirstName.Text.Equals("") && txtLastName.Text.Equals("") && txtAddress.Text.Equals("") &&
            txtContactNo.Text.Equals("") && txtEmail.Text.Equals("") && cmbProgramEnrol.SelectedIndex == -1 &&
           cmbGender.SelectedIndex == -1 && cmbProgramEnrol.SelectedIndex == -1 && cmbEnrolmentStatus.SelectedIndex == -1)
            {
                // Configure message box
                string message = "Please Fill Enrolment Form.";
                string caption = "Enrolment Form Error !";
                // Show message box
                MessageBox.Show(message, caption);

                correct = false;
            }
            else
            {

                if (txtFirstName.Text.Equals("") && txtLastName.Text.Equals(""))
                {
                    // Configure message box
                    string message = "Enter First Name and Last Name.";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;


                }
                else
                {
                    updatedStudent.Name = txtFirstName.Text + " " + txtLastName.Text;
                }

                if (txtAddress.Text.Equals(""))
                {
                    string message = "Enter Address.";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;
                }
                else
                {
                    updatedStudent.Address = txtAddress.Text;

                }

                Regex validatorPhone = new Regex("^[9]{1}[0-9]{9}$");
                string matchPhone = validatorPhone.Match(txtContactNo.Text).Value.ToString();

                if (matchPhone.Length == 10)
                {
                    updatedStudent.ContactNo = txtContactNo.Text;

                }
                else
                {
                    string message = "Enter Phone Number. [10 digit mobile number starting with 9]";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;
                }
                const string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                bool isValid = regex.IsMatch(txtEmail.Text);

                if (isValid == true)
                {
                    updatedStudent.Email = txtEmail.Text;

                }
                else
                {
                    string message = "Enter Email Address. [abc@abc.abc format]";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;
                }

                if (cmbProgramEnrol.SelectedIndex == -1)
                {
                    string message = "Choose a Program.";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;
                }
                else
                {
                    updatedStudent.ProgramEnrol = cmbProgramEnrol.SelectedItem.ToString();
                }

                if (cmbGender.SelectedIndex == -1)
                {
                    string message = "Choose a Gender.";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;
                }
                else
                {
                    updatedStudent.Gender = cmbGender.SelectedItem.ToString();
                }
                if (cmbEnrolmentStatus.SelectedIndex == -1)
                {
                    string message = "Choose Enrolment Status.";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;
                }
                else
                {
                    updatedStudent.EnrolmentStatus = cmbEnrolmentStatus.SelectedItem.ToString();
                }
                if (dTPRegistrationDate.Text.Contains("Saturday"))
                {
                    string message = "Enrolment Closed on Weekends.";
                    string caption = "Enrolment Form Error !";
                    // Show message box
                    MessageBox.Show(message, caption);
                    correct = false;
                }
                else
                {
                    updatedStudent.RegistrationDate = dTPRegistrationDate.Value;
                }

                updatedStudent.BirthDate = dTPBirthDate.Value;
            }
            if (correct == true)
            {
                updatedStudent.Edit(updatedStudent);
                BindGrid();
                btnUpdate.Visible = false;
                btnAddNewStudent.Visible = true;
                Clear();
                string message = "Student Record Edited Sucessfully.";
                string caption = "Enrolment Form";
                // Show message box
                MessageBox.Show(message, caption);

            }

           
        }
   

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panelWelcome.Visible = false;
            panelStudent.Visible = true;
            panelReport.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panelWelcome.Visible = false;
            panelStudent.Visible = false;
            panelReport.Visible = true;
        }

        private void ArrowPictureBox_Click(object sender, EventArgs e)
        {
            panelWelcome.Visible = false;
            panelStudent.Visible = true;
            panelReport.Visible = false;
        }


        private void dataGridViewReport(List<Student> studentList)

        {
            DateTime startDate = dtpReportDate.Value;
            DateTime endDate = dtpReportDate.Value.AddDays(7);

            try
            {
                var result = studentList
                    .Where(date => date.RegistrationDate >= startDate && date.RegistrationDate <= endDate)
                    .GroupBy(l => l.ProgramEnrol)
                    .Select(cl => new
                    {
                        Programme = cl.First().ProgramEnrol,
                        Count = cl.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(result);
                dataGridViewWeeklyReport.DataSource = dt; 
                

            }
            catch (Exception e) {
                MessageBox.Show(e + "Exception Occured.");
            }
        }
        private void BindChart(List<Student> studentList) 
        {
           

            if (studentList != null)
            {
                var result = studentList
                    .GroupBy(l => l.ProgramEnrol)
                    .Select(cl => new
                    {
                        ProgramEnrol = cl.First().ProgramEnrol,
                        Count = cl.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(result);
                ProgramEnrolChart.DataSource = dt;
                ProgramEnrolChart.Name = "ProgramEnrol";
                ProgramEnrolChart.Series["No of Student"].XValueMember = "ProgramEnrol";
                ProgramEnrolChart.Series["No of Student"].YValueMembers = "Count";
                this.ProgramEnrolChart.Titles.Remove(this.ProgramEnrolChart.Titles.FirstOrDefault());
                this.ProgramEnrolChart.Titles.Add("Program Enrolment Chart");
                ProgramEnrolChart.Series["No of Student"].IsValueShownAsLabel = true;
            }
        }

        private void btnGenerateWeeklyReport_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

      

        private void btnSortNameAsc_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            List<Student> listStudent = student.List();
            int count = listStudent.Count();
            bool doSwapValue;
            Student tempStudent;

            do
            {
                doSwapValue = false;
                for (int i = 0; i < count - 1; i++)
                {
                    if (string.Compare(listStudent[i].Name, listStudent[i + 1].Name, true) > 0)
                    {
                        tempStudent = listStudent[i];
                        listStudent[i] = listStudent[i + 1];
                        listStudent[i + 1] = tempStudent;
                        doSwapValue = true;

                    }
                }
            } while (doSwapValue == true);

            DataTable dataTable = Utility.ConvertToDataTable(listStudent);
            dataGridStudents.DataSource = dataTable;
        }

        private void btnSortNameDesc_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            List<Student> listStudent = student.List();
            int count = listStudent.Count();
            bool doSwapValue;
            Student tempStudent;

            do
            {
                doSwapValue = false;
                for (int i = 0; i < count - 1; i++)
                {
                    if (string.Compare(listStudent[i].Name, listStudent[i + 1].Name, true) < 0)
                    {
                        tempStudent = listStudent[i];
                        listStudent[i] = listStudent[i + 1];
                        listStudent[i + 1] = tempStudent;
                        doSwapValue = true;

                    }
                }
            } while (doSwapValue == true);

            DataTable dataTable = Utility.ConvertToDataTable(listStudent);
            dataGridStudents.DataSource = dataTable;

        }

        private void btnSortDateAsc_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            List<Student> listStudent = student.List();
            int count = listStudent.Count();
            bool doSwapValue;
            Student tempStudent;

            do
            {
                doSwapValue = false;
                for (int i = 0; i < count - 1; i++)
                {
                    if (string.Compare(listStudent[i].RegistrationDate.ToString(), listStudent[i + 1].RegistrationDate.ToString(), true) < 0)
                    {
                        tempStudent = listStudent[i];
                        listStudent[i] = listStudent[i + 1];
                        listStudent[i + 1] = tempStudent;
                        doSwapValue = true;

                    }
                }
            } while (doSwapValue == true);

            DataTable dataTable = Utility.ConvertToDataTable(listStudent);
            dataGridStudents.DataSource = dataTable;
        }

        private void btnSortDateDesc_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            List<Student> listStudent = student.List();
            int count = listStudent.Count();
            bool doSwapValue;
            Student tempStudent;

            do
            {
                doSwapValue = false;
                for (int i = 0; i < count - 1; i++)
                {
                    if (string.Compare(listStudent[i].RegistrationDate.ToString(), listStudent[i + 1].RegistrationDate.ToString(), true) > 0)
                    {
                        tempStudent = listStudent[i];
                        listStudent[i] = listStudent[i + 1];
                        listStudent[i + 1] = tempStudent;
                        doSwapValue = true;

                    }
                }
            } while (doSwapValue == true);

            DataTable dataTable = Utility.ConvertToDataTable(listStudent);
            dataGridStudents.DataSource = dataTable;
        }

  

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            BindGrid();
            Clear();
            btnUpdate.Visible = false;
            btnAddNewStudent.Visible = false;
            btnSubmit.Visible = true;
        }

    
    }
}
 