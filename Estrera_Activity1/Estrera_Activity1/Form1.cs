using System;
using System.IO;
using System.Windows.Forms;

namespace Estrera_Activity1
{
    public partial class Form1 : Form
    {
        private const string filePath = "entries.txt";

        public Form1()
        {
            InitializeComponent();
            LoadEntries();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetPlaceholderText();
            File.WriteAllText(filePath, string.Empty);  
            LoadEntries();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string familyName = txtFamilyName.Text;
            string age = txtAge.Text;
            string email = txtEmail.Text;
            string course = txtCourse.Text;

            if (string.IsNullOrWhiteSpace(firstName) || firstName == "First Name" ||
                string.IsNullOrWhiteSpace(middleName) || middleName == "Middle Name" ||
                string.IsNullOrWhiteSpace(familyName) || familyName == "Family Name" ||
                string.IsNullOrWhiteSpace(age) || age == "Age" ||
                string.IsNullOrWhiteSpace(email) || email == "Email Address" ||
                string.IsNullOrWhiteSpace(course) || course == "Course")
            {
                MessageBox.Show("All fields must be filled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (!int.TryParse(age, out _))
            {
                MessageBox.Show("Please enter a valid age", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string entry = "First Name: " + firstName + "\n" +
               "Middle Name: " + middleName + "\n" +
               "Family Name: " + familyName + "\n" +
               "Age: " + age + "\n" +
               "Email: " + email + "\n" +
               "Course: " + course + "\n\n";
               File.AppendAllText(filePath, entry);


            LoadEntries();
            ClearTextBoxes();
            SetPlaceholderText();
        }

        private void LoadEntries()
        {
            lstEntries.Items.Clear();

            if (File.Exists(filePath))
            {
                string[] entries = File.ReadAllLines(filePath);
                foreach (var entry in entries)
                {
                    lstEntries.Items.Add(entry); 
                }
            }

            if (lstEntries.Items.Count > 0)
                lstEntries.SelectedIndex = lstEntries.Items.Count - 1;
        }

        private void ClearTextBoxes()
        {
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtFamilyName.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            txtCourse.Clear();
        }

        private void SetPlaceholderText()
        {
            SetPlaceholderForTextbox(txtFirstName, "First Name");
            SetPlaceholderForTextbox(txtMiddleName, "Middle Name");
            SetPlaceholderForTextbox(txtFamilyName, "Family Name");
            SetPlaceholderForTextbox(txtAge, "Age");
            SetPlaceholderForTextbox(txtEmail, "Email Address");
            SetPlaceholderForTextbox(txtCourse, "Course");
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
    }
}
