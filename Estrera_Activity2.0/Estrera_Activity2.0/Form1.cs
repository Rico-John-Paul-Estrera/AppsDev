using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estrera_Activity2._0
{
    public partial class Form1 : Form
    {
        private const string FileName = "StudentInfo.txt";
        private string FilePath;
        private int selectedIndex = -1;

        public Form1()
        {
            InitializeComponent();
            FilePath = Path.Combine(@"Z:\II320\SEMI-FINAL\Estrera_Activity2.0\Estrera_Activity2.0\files", FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
            SetPlaceholderText();
        }

        private void txtFname_TextChanged(object sender, EventArgs e) { }
        private void txtMiddleName_TextChanged(object sender, EventArgs e) { }
        private void txtLname_TextChanged(object sender, EventArgs e) { }
        private void txtAge_TextChanged(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void txtCourse_TextChanged(object sender, EventArgs e) { }

        private void sbtBtn_Click(object sender, EventArgs e)
        {
            string firstname = txtFname.Text.Trim();
            string middleName = txtMiddleName.Text.Trim();
            string lastname = txtLname.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string email = txtEmail.Text.Trim();
            string course = txtCourse.Text.Trim();
            int age;

            if (string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(middleName) ||
                string.IsNullOrWhiteSpace(lastname) || string.IsNullOrWhiteSpace(ageText) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(course))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                age = Convert.ToInt32(ageText);
                if (age < 0 || age > 150)
                {
                    MessageBox.Show("Please enter a valid age between 0 and 150.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer for age.");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please enter a valid age within the acceptable range.");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            string studentInfo = firstname + "   |   " + middleName + "   |   " + lastname + "   |   " + age + "   |   " + email + "   |   " + course;

            try
            {
                using (StreamWriter sw = new StreamWriter(FilePath, true))
                {
                    sw.WriteLine(studentInfo);
                }

                ClearTextFields();
                MessageBox.Show("Student information saved successfully!");
                LoadStudentData();
            }
            catch (Exception)
            {
                MessageBox.Show("Error saving to file");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                string firstname = txtFname.Text.Trim();
                string middleName = txtMiddleName.Text.Trim();
                string lastname = txtLname.Text.Trim();
                string ageText = txtAge.Text.Trim();
                string email = txtEmail.Text.Trim();
                string course = txtCourse.Text.Trim();
                int age;

                if (string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(middleName) ||
                   string.IsNullOrWhiteSpace(lastname) || string.IsNullOrWhiteSpace(ageText) ||
                   string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(course))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                try
                {
                    age = Convert.ToInt32(ageText);
                    if (age < 0 || age > 150)
                    {
                        MessageBox.Show("Please enter a valid age between 0 and 150.");
                        return;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid integer for age.");
                    return;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Please enter a valid age within the acceptable range.");
                    return;
                }

                if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                string updatedStudentInfo = firstname + "  |  " + middleName + "  |  " + lastname + "  |  " + age + "  |  " + email + "  |  " + course;
                List<string> lines = File.ReadAllLines(FilePath).ToList();
                lines[selectedIndex] = updatedStudentInfo;
                File.WriteAllLines(FilePath, lines);

                LoadStudentData();
                MessageBox.Show("Record Updated");
                ClearTextFields();
            }
            else
            {
                MessageBox.Show("Please select a student to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                List<string> lines = File.ReadAllLines(FilePath).ToList();
                lines.RemoveAt(selectedIndex);
                File.WriteAllLines(FilePath, lines);

                LoadStudentData();
                MessageBox.Show("Record Deleted");
                ClearTextFields();
            }
            else
            {
                MessageBox.Show("Please select a student to Delete.");
            }
        }

        private void LoadStudentData()
        {
            listDisplay.Items.Clear();

            try
            {
                string[] lines = File.ReadAllLines(FilePath);
                foreach (string line in lines)
                {
                    listDisplay.Items.Add(line);
                }
            }
            catch (FileNotFoundException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading from file: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void listDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDisplay.SelectedIndex >= 0)
            {
                selectedIndex = listDisplay.SelectedIndex;
                string selectedStudent = listDisplay.SelectedItem.ToString();
                string[] studentDetails = selectedStudent.Split(new[] { "   |   " }, StringSplitOptions.None);

                if (studentDetails.Length == 6)
                {
                    txtFname.Text = studentDetails[0].Trim();
                    txtMiddleName.Text = studentDetails[1].Trim();
                    txtLname.Text = studentDetails[2].Trim();
                    txtAge.Text = studentDetails[3].Trim();
                    txtEmail.Text = studentDetails[4].Trim();
                    txtCourse.Text = studentDetails[5].Trim();

                    txtFname.ForeColor = Color.Black;
                    txtMiddleName.ForeColor = Color.Black;
                    txtLname.ForeColor = Color.Black;
                    txtAge.ForeColor = Color.Black;
                    txtEmail.ForeColor = Color.Black;
                    txtCourse.ForeColor = Color.Black;
                }
            }
        }

        private void SetPlaceholderText()
        {
            SetPlaceholderForTextbox(txtFname, "First Name");
            SetPlaceholderForTextbox(txtMiddleName, "Middle Name");
            SetPlaceholderForTextbox(txtLname, "Last Name");
            SetPlaceholderForTextbox(txtEmail, "Email Address");
            SetPlaceholderForTextbox(txtCourse, "Course");
            SetPlaceholderForTextbox(txtAge, "Age");
        }

        private void SetPlaceholderForTextbox(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = System.Drawing.Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void ClearTextFields()
        {
            txtFname.Clear();
            txtMiddleName.Clear();
            txtLname.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            txtCourse.Clear();
        }

        private void richTextBoxDisplay_TextChanged(object sender, EventArgs e) { }
    }
}
