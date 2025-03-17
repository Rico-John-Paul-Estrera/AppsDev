namespace Activity2B
{
    public partial class Form1 : Form
    {
        string currentInput = "";
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int idNum, yearLvl, age;

            if (!int.TryParse(textBox1.Text, out idNum) ||
                !int.TryParse(textBox3.Text, out yearLvl) ||
                !int.TryParse(textBox11.Text, out age))
            {
                MessageBox.Show("Please enter valid numeric values for ID, Year Level, Age, Phone Number, and Parent Contact Number.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string course = textBox2.Text;
            string fName = textBox4.Text;
            string mName = textBox15.Text;
            string lName = textBox5.Text;
            string emailAdd = textBox6.Text;
            string homeAdd = textBox7.Text;
            string fatherName = textBox8.Text;
            string motherName = textBox9.Text;
            string dateBirth = textBox10.Text;
            string phoneNum = textBox12.Text;
            string parentNum = textBox13.Text;
            string skills = textBox14.Text;

            Form2 newForm = new Form2 (idNum, course, yearLvl, fName, mName, lName, emailAdd, homeAdd, fatherName, motherName, dateBirth, age, phoneNum, parentNum, skills);


            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
                textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" ||
                textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" ||
                textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "")
            {
                MessageBox.Show("Please fill in all  required fields below before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.Hide();
                newForm.ShowDialog();
                this.Close();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
