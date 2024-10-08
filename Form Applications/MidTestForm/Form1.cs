﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MidTestForm
{
    public partial class Form1 : Form

    {
        string cs = "Data Source=DESKTOP-QJQVCGL\\SQLEXPRESS06;Initial Catalog=Employee;Integrated Security=True;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (con = new SqlConnection(cs)) {
                adapter = new SqlDataAdapter("SELECT * FROM Employees", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        
        private void Clear()
        {
            txtEmployeeID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }

        private void Parameters()
        {
            cmd.Parameters.AddWithValue("EmployeeID", txtEmployeeID.Text);
            cmd.Parameters.AddWithValue("FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("PhotoPath", employeeImage.ImageLocation);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            txtEmployeeID.Text = selectedRow.Cells[0].Value.ToString();
            txtFirstName.Text = selectedRow.Cells[1].Value.ToString();
            txtLastName.Text = selectedRow.Cells[2].Value.ToString();
            txtEmail.Text = selectedRow.Cells[3].Value.ToString();
            txtPhone.Text = selectedRow.Cells[4].Value.ToString();
            employeeImage.ImageLocation = selectedRow.Cells[5].Value.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeeDataSet.Employees);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                cmd = new SqlCommand("INSERT INTO Employees (FirstName, LastName, Email, Phone, PhotoPath) VALUES (@FirstName, @LastName, @Email, @Phone, @PhotoPath) ", con);
                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
                MessageBox.Show("Record Added Succesfully");
                Clear();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID=@EmployeeID", con);
                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
                MessageBox.Show("Record Deleted Succesfully");
                Clear();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                cmd = new SqlCommand("UPDATE Employees SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Phone=@Phone, PhotoPath=@PhotoPath WHERE EmployeeID=@EmployeeID", con);
                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
                MessageBox.Show("Record Updated Succesfully");
                Clear();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void csvSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string[] data = {
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        row.Cells[3].Value.ToString(),
                        row.Cells[4].Value.ToString(),
                        row.Cells[5].Value.ToString()
                    };
                            sw.WriteLine(string.Join(",", data));
                        }
                    }
                }
                MessageBox.Show("Data saved to CSV successfully!");
            }
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                employeeImage.ImageLocation = ofd.FileName;
            }
        }
    }
}
