namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void additionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double sum = number1 + number2;

            textBox3.Text = sum.ToString();
        }

        private void substractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double difference = number1 - number2;

            textBox3.Text = difference.ToString();
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double product = number1 * number2;

            textBox3.Text = product.ToString();
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double division = number1 / number2;

            textBox3.Text = division.ToString();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
