using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ShopApp
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
            string filePath = "C:\\Users\\Roby\\Desktop\\Uni Stuff\\An3Sem2\\II\\ShopApp\\login.txt";
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length >= 2)
            {
                string storedUsername = lines[0];
                string storedPassword = lines[1];
                if (UsernameBox.Text == storedUsername && PasswordBox.Text == storedPassword)
                {
                    new Form2().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username of password incorrect, try again");
                    UsernameBox.Clear();
                    PasswordBox.Clear();
                    UsernameBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials. Make sure it contains username and password");
            }
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
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
