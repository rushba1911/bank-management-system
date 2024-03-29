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
    public partial class customerop6b : Form
    {
        public customerop6b()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            customerop6 u = new customerop6();
            this.Close();
            u.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string accnum = textBox1.Text;
            string sourceofincome = textBox2.Text;
            try
            {
                bool check = CustomerDL.UpdateSourceOfIncome(accnum, sourceofincome);
                if (check)
                {
                    MessageBox.Show("Source of Income Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    customerop6 u = new customerop6();
                    this.Close();
                    u.Show();
                }
                else
                {
                    MessageBox.Show("The Account Number you provided does not exist in this system.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
