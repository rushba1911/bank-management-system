using BA.Clerk;
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
    public partial class clerkop2 : Form
    {
        public clerkop2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clerkinterface c = new clerkinterface();
            this.Close();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filepath = "textfile.txt";
            string accnum = textBox1.Text;
            string name = textBox2.Text;
            try
            {
                bool check = ClerkDL.DeleteRecordofCustomer(accnum, name, filepath);
                if (check)
                {
                    MessageBox.Show("Customer account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CustomerDL.readData(filepath);
                    clerkinterface c = new clerkinterface();
                    this.Close();
                    c.Show();
                }
                else
                {
                    MessageBox.Show("The Credentials you provided for Customer does not exist in this System.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
