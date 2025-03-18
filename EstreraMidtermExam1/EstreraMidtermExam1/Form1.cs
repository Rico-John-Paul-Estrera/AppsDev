namespace EstreraMidtermExam1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] votes = { txtVote1.Text.Trim().ToUpper(), txtVote2.Text.Trim().ToUpper(), txtVote3.Text.Trim().ToUpper() };

            int yesCount = 0, noCount = 0;

            foreach (string vote in votes)
            {
                if (vote == "YES") yesCount++;
                else if (vote == "NO") noCount++;
            }

            if (yesCount >= 2)
                lblResult.Text = "DECISION: YES";
            else if (noCount >= 2)
                lblResult.Text = "DECISION: NO";
            else
                lblResult.Text = "INVALID INPUT"; 
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
