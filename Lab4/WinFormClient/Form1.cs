using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormClient.ServiceReference1;

namespace WinFormClient
{
    public partial class Form1 : Form
    {
        private WebService1SoapClient client;
        public Form1()
        {
            InitializeComponent();
            client = new WebService1SoapClient();
            try
            {
                // Assuming listBox1 is the ListBox control on your form
                listBox1.DataSource = client.getListOfElements();
                listBox1.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String result = client.HelloWorld();
            MessageBox.Show(result);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assuming textBox1 contains the Fahrenheit value entered by the user
            if (double.TryParse(textBox1.Text, out double fahrenheit))
            {
                // Call the method to convert Fahrenheit to Celsius
                double celsius = client.fromFtoC(fahrenheit);

                // Display the result
                textBox3.Text = celsius.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number for Fahrenheit.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(double.TryParse(textBox2.Text, out double celsius))
            {
                double fahrenheit = client.fromCtoF(celsius);
                textBox3.Text = fahrenheit.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number for Celsius");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox6.Text, out double euro))
            {
                double lei = client.euroToLei(euro);
                textBox4.Text = lei.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number for Celsius");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox6.Text, out double lei))
            {
                double euro = client.leiToEuro(lei);
                textBox5.Text = euro.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number for Celsius");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
