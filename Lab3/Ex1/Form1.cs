using Ex1.Database2DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        SqlConnection myConnection = new SqlConnection();
        DataSet dsUniv;
        DataSet dsFac;
        public Form1()
        {
            InitializeComponent();
            InitializeData();
            dataGridView1.DataSource = dsFac.Tables["Facultati"];
            dataGridView1.CellClick += dataGridView1_CellContentClick;

        }
        private void InitializeData()
        {
            myConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Roby\Desktop\Uni Stuff\An3Sem2\II\Lab3\Ex1\Database2.mdf;Integrated Security=True";
            myConnection.Open();
            dsUniv = new DataSet();
            dsFac = new DataSet();
            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myConnection);
            daUniv.Fill(dsUniv, "Universitati");
            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Facultati", myConnection);
            daFac.Fill(dsFac, "Facultati");
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                listBox_Univ.Items.Add(name);
            }
            myConnection.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Fac.Items.Clear();
            textBox_City.Clear();
            textBox_CodeUniv.Clear();
            int code = 0;

            if(listBox_Univ.SelectedItem != null){
                String UnivSelected = listBox_Univ.SelectedItem.ToString();
                foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
                {
                    if (UnivSelected == dr.ItemArray.GetValue(1).ToString())
                    {
                        textBox_City.Text = dr.ItemArray.GetValue(2).ToString();
                        code = Convert.ToInt32(dr.ItemArray.GetValue(3));
                        textBox_CodeUniv.Text = code.ToString();
                    }
                }
                foreach (DataRow dr in dsFac.Tables["Facultati"].Rows)
                {
                    if (code == Convert.ToInt32(dr.ItemArray.GetValue(1)))
                    {
                        String nameFac = dr.ItemArray.GetValue(2).ToString();
                        listBox_Fac.Items.Add(nameFac);
                    }
                }
            }
            /* else
            {
                MessageBox.Show("Entity not selected!");
            } */
        }

        private void InsertUniversity(int Id, string NameUniv, string City, int Code)
        {
            myConnection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Universitati (Id, NameUniv, City, Code) VALUES (@Id, @NameUniv, @City, @Code)", myConnection);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@NameUniv", NameUniv);
            cmd.Parameters.AddWithValue("@City", City);
            cmd.Parameters.AddWithValue("@Code", Code);
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textBox_newId.Text);
            string NameUniv = textBox_newUniv.Text;
            string City = textBox_newCity.Text;
            int Code = Convert.ToInt32(textBox_newCode.Text);
            InsertUniversity(Id, NameUniv, City, Code);
            listBox_Univ.Items.Clear();
            InitializeData();
        }
        private void DeleteUniversity(int Code)
        {
            myConnection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Universitati WHERE Code = @Code", myConnection);
            cmd.Parameters.AddWithValue("@Code", Code);
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Code = Convert.ToInt32(textBox_CodeUniv.Text);
            DeleteUniversity(Code);
            listBox_Univ.Items.Clear();
            InitializeData();
        }
        private void UpdateUniversity(int newId, string newNameUniv, string newCity, int Code)
        {
            myConnection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Universitati SET Id = @NewId, NameUniv = @NewName, City = @NewCity WHERE Code = @Code", myConnection);
            cmd.Parameters.AddWithValue("@NewId", newId);
            cmd.Parameters.AddWithValue("@NewName", newNameUniv);
            cmd.Parameters.AddWithValue("@NewCity", newCity);
            cmd.Parameters.AddWithValue("@Code", Code);
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int newId = Convert.ToInt32(textBox_newId.Text);
            string newNameUniv = textBox_newUniv.Text;
            string newCity = textBox_newCity.Text;
            int Code = Convert.ToInt32(textBox_CodeUniv.Text);
            UpdateUniversity(newId, newNameUniv, newCity, Code);
            listBox_Univ.Items.Clear();
            InitializeData();
        }
        private void DeleteFac(int facId)
        {
            myConnection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Facultati WHERE Id = @Id", myConnection);
            cmd.Parameters.AddWithValue("@Id", facId);
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex < dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int facId = Convert.ToInt32(row.Cells["Id"].Value);
                    DeleteFac(facId);
                    InitializeData();
                }
            }
        } 
    }
}
