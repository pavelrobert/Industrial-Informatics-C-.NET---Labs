using System.IO;
namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Roby\\Desktop\\Uni Stuff\\An3Sem2\\II\\Lab2\\Ex1\\login.txt";
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length >= 2)
            {
                string storedUsername = lines[0];
                string storedPassword = lines[1];
                if (txtUserName.Text == storedUsername && txtPassword.Text == storedPassword)
                {
                    new Form2().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username of password incorrect, try again");
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials. Make sure it contains username and password");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
