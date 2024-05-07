using System.Linq.Expressions;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] lines = File.ReadAllLines(path: "C:\\Users\\Roby\\Desktop\\Uni Stuff\\An3Sem2\\II\\Lab2\\Ex2\\list.txt");
            listBox1.Items.AddRange(lines);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.TopIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SetSelected(i, true);
            } */
            {
                foreach (var item in listBox1.SelectedItems)
                {
                    if (!listBox2.Items.Contains(item))
                    {
                        listBox2.Items.Add(new ListViewItem(item.ToString()));

                    }
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
