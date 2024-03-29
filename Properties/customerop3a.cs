﻿using BA.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Properties
{
    public partial class customerop3a : Form
    {
        private string accnum;
        public customerop3a(string accnum)
        {
            this.accnum = accnum;
            InitializeComponent();
            dataGridView1.Columns.Add("AccountNumber", "Account Number");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Password", "Password");
            dataGridView1.Columns.Add("Source Of Income", "Source Of Income");
            dataGridView1.Columns.Add("Address", "Address");
            dataGridView1.Columns.Add("Account Type", "Account Type");
            dataGridView1.Columns.Add("Amount", "Amount");
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11);
            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
        }
        private void customerop3a_Load(object sender, EventArgs e)
        {
            string filePath = "textfile.txt";
            try
            {
                List<string> records = CustomerDL.ReadCustomerRecord(filePath, accnum);

                dataGridView1.Rows.Clear();
                foreach (string record in records)
                {
                    string[] values = record.Split(',');
                    dataGridView1.Rows.Add(values);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            customerinterface c = new customerinterface();
            this.Close();
            c.Show();
        }
    }
}
