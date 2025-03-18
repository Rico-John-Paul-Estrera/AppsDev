namespace EstreraMidtermExam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtSideA.Text, out double a) &&
                double.TryParse(txtSideB.Text, out double b) &&
                double.TryParse(txtSideC.Text, out double c))
            {
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    lblResult.Text = "Invalid Triangle";
                }
                else if (a + b <= c || a + c <= b || b + c <= a)
                {
                    lblResult.Text = "Invalid Triangle";
                }
                else if (a == b && b == c)
                {
                    lblResult.Text = "Equilateral Triangle";
                }
                else if (a == b || a == c || b == c)
                {
                    lblResult.Text = "Isosceles Triangle";
                }
                else
                {
                    lblResult.Text = "Scalene Triangle";
                }
            }
            else
            {
                lblResult.Text = "Please enter valid numbers.";
            } 
        }
    }
}
