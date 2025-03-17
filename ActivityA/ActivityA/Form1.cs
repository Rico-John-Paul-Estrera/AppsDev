namespace ActivityA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int labRules = Convert.ToInt32(Console.ReadLine());
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int labRules = Convert.ToInt32(textBox1.Text);
            switch (labRules)
            {
                case 1:
                    MessageBox.Show("Maintain silence, proper decorum, and discipline inside the laboratory. Mobile phones, walkmans and other personal pieces of equipment must be switched off.", "LAB RULE NUMBER 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Games are not allowed inside the lab. This includes computer-related games, card games and other games that may disturb the operation of the lab.", "LAB RULE NUMBER 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show("Surfing the Internet is allowed only with the permission of the instructor. Downloading and installing of software are strictly prohibited.", "LAB RULE NUMBER 3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 4:
                    MessageBox.Show("Getting access to other websites not related to the course (especially pornographic and illicit sites) is strictly prohibited.", "LAB RULE NUMBER 4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 5:
                    MessageBox.Show("Deleting computer files and changing the set-up of the computer is a major offense.", "LAB RULE NUMBER 5", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 6:
                    MessageBox.Show("Observe computer time usage carefully. A fifteen-minute allowance is given for each use. Otherwise, the unit will be given to those who wish to sit-in", "LAB RULE NUMBER 6", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 7:
                    MessageBox.Show("Observe proper decorum while inside the laboratory."           + Environment.NewLine + Environment.NewLine +
                        "a. Do not get inside the lab unless the instructor is present."            + Environment.NewLine +
                        "b. All bags, knapsacks, and the likes must be deposited at the counter."   + Environment.NewLine +
                        "c. Follow the seating arrangement of your instructor."                     + Environment.NewLine +
                        "d. At the end of class, all software programs must be closed."             + Environment.NewLine +
                        "e. Return all chairs to their proper places after using.", "LAB RULE NUMBER 7", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 8:
                    MessageBox.Show("Chewing gum, eating, drinking, smoking, and other forms of vandalism are prohibited inside the lab.", "LAB RULE NUMBER 8", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 9:
                    MessageBox.Show("Anyone causing a continual disturbance will be asked to leave the lab. Acts or gestures offensive to the members of the community, including public display of physical intimacy, are not tolerated.", "LAB RULE NUMBER 9", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 10:
                    MessageBox.Show("Persons exhibiting hostile or threatening behavior such as yelling, swearing, or disregarding requests made by lab personnel will be asked to leave the lab.", "LAB RULE NUMBER 10", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 11:
                    MessageBox.Show("For serious offense, the lab personnel may call the Civil Security Office (CSU) for assistance.", "LAB RULE NUMBER 11", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 12:
                    MessageBox.Show("Any technical problem or difficulty must be addressed to the laboratory supervisor, student assistant or instructor immediately.", "LAB RULE NUMBER 12", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Invalid number!" + Environment.NewLine + "Please choose a number between 1 and 12 only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
