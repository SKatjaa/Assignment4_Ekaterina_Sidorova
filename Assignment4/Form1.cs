namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(textBox1.Text, out number)) { } 
            else 
            {
                label2.Visible = true;
                label2.Text = "Enter valid type of data";
            }

            int factorial, start;
            //start = 1;
            //factorial = 1;

            if (number > 0)
            {
                start = 1;
                factorial = 1;
                while (start <= number)
                {
                    factorial = factorial * start;
                    start++;
                }
                /*
                for (start = 1; start <= number;start++)
                {
                    factorial = factorial * start;
                }
                */

                label2.Visible = true;
                label2.Text = "Factorial is " + factorial;
            }

            else if (number <0)
            {
                label2.Visible = true;
                label2.Text = "Enter nonnegative integer";
            } 
            else if (textBox1.Text == "0")
            {
                label2.Visible = true;
                label2.Text = "Factorial is 1";
            }
        }
    }
}