using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2B
{
    public partial class Form2 : Form
    {
        private int idNum, yearLvl, age;
        private string  course, fName, mName, lName, emailAdd, homeAdd, fatherName, motherName, dateBirth, phoneNum, parentNum, skills;

        public Form2(int idNum, string course, int yearLvl, string fName, string mName, string lName,
                 string emailAdd, string homeAdd, string fatherName, string motherName,
                 string dateBirth, int age, string phoneNum, string parentNum, string skills)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


            this.idNum = idNum;
            this.course = course;
            this.yearLvl = yearLvl;
            this.fName = fName;
            this.mName = mName;
            this.lName = lName;
            this.emailAdd = emailAdd;
            this.homeAdd = homeAdd;
            this.fatherName = fatherName;
            this.motherName = motherName;
            this.dateBirth = dateBirth;
            this.age = age;
            this.phoneNum = phoneNum;
            this.parentNum = parentNum;
            this.skills = skills;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label4.Text = radioButton1.Text;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label4.Text = radioButton2.Text;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label4.Text = radioButton3.Text;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label4.Text = radioButton4.Text;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                label4.Text = radioButton5.Text;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                label4.Text = radioButton6.Text;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                label4.Text = radioButton7.Text;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                label4.Text = radioButton8.Text;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                label4.Text = radioButton9.Text;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                label4.Text = radioButton10.Text;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                label4.Text = radioButton11.Text;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                label4.Text = radioButton12.Text;
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked)
            {
                label4.Text = radioButton13.Text;
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            {
                label4.Text = radioButton14.Text;
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                label4.Text = radioButton15.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                label5.Text = idNum.ToString();
            }
            else if (radioButton2.Checked)
            {
                label5.Text = course;
            }
            else if (radioButton3.Checked)
            {
                label5.Text = yearLvl.ToString();
            }
            else if (radioButton4.Checked)
            {
                label5.Text = fName;
            }
            else if (radioButton5.Checked)
            {
                label5.Text = mName; 
            }
            else if (radioButton6.Checked)
            {
                label5.Text = lName;
            }
            else if (radioButton7.Checked)
            {
                label5.Text = emailAdd;
            }
            else if (radioButton8.Checked)
            {
                label5.Text = homeAdd;
            }
            else if (radioButton9.Checked)
            {
                label5.Text = fatherName;
            }
            else if (radioButton10.Checked)
            {
                label5.Text = motherName;
            }
            else if (radioButton11.Checked)
            {
                label5.Text = dateBirth;
            }
            else if (radioButton12.Checked)
            {
                label5.Text = age.ToString() + " Years Old";
            }
            else if (radioButton13.Checked)
            {
                label5.Text = phoneNum;
            }
            else if (radioButton14.Checked)
            {
                label5.Text = parentNum;
            }
            else if (radioButton15.Checked)
            {
                label5.Text = skills;
            }
            else if (radioButton16.Checked)
            {
                label5.Text = fName + " " + mName + " " + lName;
            }
            else
            {
                MessageBox.Show("Please select an option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
            {
                label4.Text = radioButton16.Text;
            }
        }
    }
}
