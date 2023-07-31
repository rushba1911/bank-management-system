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
    public partial class customerop7 : Form
    {
        public customerop7()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string accnum = textBox1.Text;
            string name = textBox2.Text;
            string password = textBox3.Text;
            try
            {
                bool check = CustomerDL.DeleteAccount(accnum, name, password);
                if (check)
                {
                    MessageBox.Show("Your Account has been Terminated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 f = new Form1();
                    this.Close();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("You have provided the wrong Credentials to Terminate Account.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            customerinterface c = new customerinterface();
            this.Close();
            c.Show();
        }
    }
}
