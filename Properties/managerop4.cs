using BA.Bank;
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
    public partial class managerop4 : Form
    {
        public managerop4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            managerinterface m = new managerinterface();
            this.Close();
            m.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string filepath = "bankinfo.txt";
            string bankName = textBox1.Text;
            string location = textBox2.Text;
            string branchCode = textBox3.Text;
            string openingTime = textBox4.Text;
            string closingTime = textBox5.Text;
            try
            {
                BankBL b = new BankBL(bankName, location, branchCode, openingTime, closingTime);
                BankBL.UpdateBankDetails(b, filepath);
                MessageBox.Show("Details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                managerinterface m = new managerinterface();
                this.Close();
                m.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
