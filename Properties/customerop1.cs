using BA.Customer;
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
    public partial class customerop1 : Form
    {
        public customerop1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            customerinterface c = new customerinterface();
            this.Close();
            c.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string accnum = textBox1.Text;
            double amount = double.Parse(textBox2.Text);
            try
            {
                bool check = CustomerDL.DepositMoney(accnum, amount);
                if (check)
                {
                    MessageBox.Show("Amount Deposited Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    customerinterface c = new customerinterface();
                    this.Close();
                    c.Show();
                }
                else
                {
                    MessageBox.Show("The Account Number you provided does not exist in this system.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
