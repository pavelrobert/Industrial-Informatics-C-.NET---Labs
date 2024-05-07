using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
        }
        public class CartItem
        {
            public string Name { get; }
            public decimal Price { get; }
            public int Quantity { get; set; }
            public CartItem(string name, decimal price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
            public decimal getTotalPrice()
            {
                return Price * Quantity;
            }
        }
        public class Order
        {
            public int OrderId { get; set; }
            public List<string> Items { get; set; }

            public Order(int orderId)
            {
                OrderId = orderId;
                Items = new List<string>();
            }
        }
        private List<Order> ordersList = new List<Order>();
        private void UpdateTotalValue()
        {
            decimal totalValue = 0;
            foreach (var item in listBox1.Items)
            {
                // Assuming each item is displayed as "Name - Price"
                string[] parts = item.ToString().Split(new string[] { " - $" }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    // Parse the price and add it to the total value
                    if (decimal.TryParse(parts[1], out decimal price))
                    {
                        totalValue += price;
                    }
                }
            }
            label8.Text = $"${totalValue:F2}"; // Display the total value with two decimal places
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            if (form2 != null)
            {
                // Find the TabControl named "tabControl1" within Form2
                TabControl tabControl = form2.Controls.Find("tabControl1", true).FirstOrDefault() as TabControl;
                if (tabControl != null)
                {
                    // Set the selected tab to the "Shop" tab (index 2)
                    tabControl.SelectedIndex = 2;
                }
                else
                {
                    MessageBox.Show("The TabControl named 'tabControl1' was not found within Form2.");
                }
            }
            else
            {
                MessageBox.Show("Form2 is not open.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void devicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            if (form2 != null)
            {
                // Find the ListBox named "listBox1" within Form2
                ListBox listBox = form2.Controls.Find("listBox1", true).FirstOrDefault() as ListBox;
                if (listBox != null)
                {
                    CartItem newItem = new CartItem("Batman Arkham Asylum", 9.99m, 1);
                    // Add the corresponding item to listBox1
                    listBox.Items.Add($"{newItem.Name} - ${newItem.Price}");
                    // form2.shoppingCart.Add(newItem);
                    form2.UpdateTotalValue();
                }
                else
                {
                    MessageBox.Show("The ListBox named 'listBox1' was not found within Form2.");
                }
            }
            else
            {
                MessageBox.Show("Form2 is not open.");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            if (form2 != null)
            {
                // Find the ListBox named "listBox1" within Form2
                ListBox listBox = form2.Controls.Find("listBox1", true).FirstOrDefault() as ListBox;
                if (listBox != null)
                {
                    CartItem newItem = new CartItem("The Last of Us", 14.99m, 1);
                    // Add the corresponding item to listBox1
                    listBox.Items.Add($"{newItem.Name} - ${newItem.Price}");
                    form2.UpdateTotalValue();
                }
                else
                {
                    MessageBox.Show("The ListBox named 'listBox1' was not found within Form2.");
                }
            }
            else
            {
                MessageBox.Show("Form2 is not open.");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            if (form2 != null)
            {
                // Find the ListBox named "listBox1" within Form2
                ListBox listBox = form2.Controls.Find("listBox1", true).FirstOrDefault() as ListBox;
                if (listBox != null)
                {
                    CartItem newItem = new CartItem("Star Wars Jedi Fallen Order", 19.99m, 1);
                    // Add the corresponding item to listBox1
                    listBox.Items.Add($"{newItem.Name} - ${newItem.Price}");
                    form2.UpdateTotalValue();
                }
                else
                {
                    MessageBox.Show("The ListBox named 'listBox1' was not found within Form2.");
                }
            }
            else
            {
                MessageBox.Show("Form2 is not open.");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            if (form2 != null)
            {
                // Find the ListBox named "listBox1" within Form2
                ListBox listBox = form2.Controls.Find("listBox1", true).FirstOrDefault() as ListBox;
                if (listBox != null)
                {
                    CartItem newItem = new CartItem("Bioshock Infinite", 12.99m, 1);
                    // Add the corresponding item to listBox1
                    listBox.Items.Add($"{newItem.Name} - ${newItem.Price}");
                    form2.UpdateTotalValue();
                }
                else
                {
                    MessageBox.Show("The ListBox named 'listBox1' was not found within Form2.");
                }
            }
            else
            {
                MessageBox.Show("Form2 is not open.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Check if any item is selected in the listBox1
            if (listBox1.SelectedItem != null)
            {
                // Remove the selected item from listBox1
                listBox1.Items.Remove(listBox1.SelectedItem);

                // Update the total value label
                UpdateTotalValue();
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private int orderCounter = 1;
        private void button9_Click(object sender, EventArgs e)
        {
            Order order = new Order(orderCounter);
            orderCounter++;

            // Calculate the total order value
            decimal totalValue = 0;
            foreach (var item in listBox1.Items)
            {
                string[] parts = item.ToString().Split(new string[] { " - $" }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    if (decimal.TryParse(parts[1], out decimal price))
                    {
                        totalValue += price;
                    }
                }
            }
            // Add items from listBox1 to the order
            foreach (var item in listBox1.Items)
            {
                order.Items.Add(item.ToString());
            }

            // Add the order to the "Account" tab
            // Assuming accountTabPage is the TabPage for the "Account" tab
            listBox2.Items.Add($"Order #{order.OrderId}{(totalValue >= 50 ? " + gift" : "")}");
            ordersList.Add(order);
            MessageBox.Show("Order placed successfully! Check the Account.");
            label8.Text = "$0.00";
            listBox1.Items.Clear();

            // Update progress bar
            if (totalValue >= 50)
            {
                progressBar1.Value = 100;
            }
            else
            {
                // Calculate the percentage of completion
                decimal percentage = (totalValue / 50) * 100;
                // Set the value of the progress bar based on the percentage
                progressBar1.Value = Convert.ToInt32(percentage);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear previous selection
            listBox3.Items.Clear();

            // Get the selected order
            int selectedIndex = listBox2.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < ordersList.Count)
            {
                // Get the selected order from the ordersList
                Order selectedOrder = ordersList[selectedIndex];

                // Display order items in listBox3
                foreach (var item in selectedOrder.Items)
                {
                    listBox3.Items.Add(item);
                }
            } 
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
