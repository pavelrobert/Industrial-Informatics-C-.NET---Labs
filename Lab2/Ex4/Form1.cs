using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                // Read lines from the file and add them to listBox1
                string[] lines = File.ReadAllLines("C:\\Users\\Roby\\Desktop\\Uni Stuff\\An3Sem2\\II\\Lab2\\Ex4\\list.txt");
                listBox1.Items.AddRange(lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                switch (listBox1.SelectedItem.ToString())
                {
                    case "The_Last_of_Us":
                        // pictureBox1.Image = Properties.Resources.The_Last_of_Us;
                        pictureBox1.Image = Image.FromFile(@"C:\path\to\The_Last_of_Us.jpg");
                        break;
                    case "Bioshock_Infinite":
                        pictureBox1.Image = Properties.Resources.Bioshock_Infinite;
                        break;
                    case "Star_Wars_Jedi_Fallen_Order":
                        pictureBox1.Image = Properties.Resources.Star_Wars_Jedi_Fallen_Order;
                        break;
                    case "Batman_Arkham_Asylum":
                        pictureBox1.Image = Properties.Resources.Batman_Arkham_Asylum;
                        break;
                    default:
                        break;
                }
            }

            /* if (listBox1.SelectedItem.Equals("The_Last_of_Us"))
                pictureBox1.Image = Properties.Resources.The_Last_of_Us;
            else if (listBox1.SelectedItem.Equals("Bioshock_Infinite"))
                pictureBox1.Image = Properties.Resources.Bioshock_Infinite; */
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItems != null)
                {
                    switch (listBox1.SelectedItem.ToString())
                    {
                        case "The_Last_of_Us":
                            pictureBox1.Image = Properties.Resources.The_Last_of_Us;
                            break;
                        case "Bioshock_Infinite":
                            pictureBox1.Image = Properties.Resources.Bioshock_Infinite;
                            break;
                        case "Star_Wars_Jedi_Fallen_Order":
                            pictureBox1.Image = Properties.Resources.Star_Wars_Jedi_Fallen_Order;
                            break;
                        case "Batman_Arkham_Asylum":
                            pictureBox1.Image = Properties.Resources.Batman_Arkham_Asylum;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Select an item from the list!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("An error occured " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Picture Clicked!");
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
