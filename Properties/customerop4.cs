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
    public partial class customerop4 : Form
    {
        public customerop4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            string name = textBox2.Text;
            string feedback = textBox3.Text;
            try
            {
                bool check = CustomerDL.TakeFeedback(accnum, name, feedback);
                if (check)
                {
                    MessageBox.Show("Feedback Submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    customerinterface c = new customerinterface();
                    this.Close();
                    c.Show();
                }
                else
                {
                    MessageBox.Show("The Credentials you provided does not exist in this System.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
