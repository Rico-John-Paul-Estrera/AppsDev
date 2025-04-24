using System;
using System.Windows.Forms;
using System.IO;

namespace Estrera_Activity2
{
    public partial class Form1 : Form
    {
        private string filePath = "userdata.txt";

        public Form1()
        {
            InitializeComponent();
            SetPlaceholderText();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {
            // Add code to handle the lblDisplay click event, if needed
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            // You can add functionality here if needed
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            // You can add functionality here if needed
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            // You can add functionality here if needed
        }

        private void numAge_ValueChanged(object sender, EventArgs e)
        {
            // You can add functionality here if needed
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            // You can add functionality here if needed
        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {
            // You can add functionality here if needed
        }

        private void richTextBoxDisplay_TextChanged(object sender, EventArgs e)
        {
            richTextBoxDisplay.ReadOnly = true;
        }

        private void sbtBtn_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string firstName = txtFirstName.Text.Trim();
            string middleName = txtMiddleName.Text.Trim();
            string familyName = txtLastName.Text.Trim();
            int age = (int)numAge.Value;
            string email = txtEmail.Text.Trim();
            string course = txtCourse.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(familyName) || string.IsNullOrWhiteSpace(course))
            {
                MessageBox.Show("Please fill in all the required fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userData = "Name: " + firstName + " " + middleName + " " + familyName + Environment.NewLine +
                   "Age: " + age.ToString() + Environment.NewLine +
                   "Email: " + email + Environment.NewLine +
                   "Course: " + course + Environment.NewLine +
                   "---------------------------------------" + Environment.NewLine;

            richTextBoxDisplay.AppendText(userData);
            try
            {
                File.AppendAllText(filePath, userData + Environment.NewLine);
                MessageBox.Show("Information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Ensure something is selected in the RichTextBox
            if (richTextBoxDisplay.SelectionLength == 0)
            {
                MessageBox.Show("Please highlight a full record to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collect updated information from input fields
            string firstName = txtFirstName.Text.Trim();
            string middleName = txtMiddleName.Text.Trim();
            string familyName = txtLastName.Text.Trim();
            int age = (int)numAge.Value;
            string email = txtEmail.Text.Trim();
            string course = txtCourse.Text.Trim();

            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(familyName) || string.IsNullOrWhiteSpace(course))
            {
                MessageBox.Show("Please fill in all the required fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Construct the updated user data string
            string updatedUserData = "Name: " + firstName + " " + middleName + " " + familyName + Environment.NewLine +
                                     "Age: " + age.ToString() + Environment.NewLine +
                                     "Email: " + email + Environment.NewLine +
                                     "Course: " + course + Environment.NewLine +
                                     "---------------------------------------" + Environment.NewLine;

            // Remove the highlighted record and replace it with updated information
            string updatedText = richTextBoxDisplay.Text.Remove(richTextBoxDisplay.SelectionStart, richTextBoxDisplay.SelectionLength);
            updatedText = updatedText.Insert(richTextBoxDisplay.SelectionStart, updatedUserData);

            // Update the RichTextBox with the new text
            richTextBoxDisplay.Text = updatedText;

            // Save the updated data to the file
            try
            {
                File.WriteAllText(filePath, updatedText);
                MessageBox.Show("Information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving the file:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ensure something is selected
            if (richTextBoxDisplay.SelectionLength == 0)
            {
                MessageBox.Show("Please highlight a full record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Remove the selected text from the RichTextBox
            string updatedText = richTextBoxDisplay.Text.Remove(richTextBoxDisplay.SelectionStart, richTextBoxDisplay.SelectionLength);

            // Optional: clean up extra newlines
            updatedText = updatedText.Replace(Environment.NewLine + Environment.NewLine + Environment.NewLine, Environment.NewLine + Environment.NewLine);

            // Update RichTextBox and file
            richTextBoxDisplay.Text = updatedText;

            try
            {
                File.WriteAllText(filePath, updatedText);
                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving the file:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetPlaceholderText()
        {
            SetPlaceholderForTextbox(txtFirstName, "First Name");
            SetPlaceholderForTextbox(txtMiddleName, "Middle Name");
            SetPlaceholderForTextbox(txtLastName, "Last Name");
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
