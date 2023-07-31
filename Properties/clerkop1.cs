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
    public partial class clerkop1 : Form
    {
        public clerkop1()
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
            string path = "textfile.txt";
            string accnum = textBox1.Text;
            string name = textBox2.Text;
            string temppassword = textBox3.Text;
            string income = textBox4.Text;
            string address = textBox5.Text;
            string acctype = textBox6.Text;
            double amount = double.Parse(textBox7.Text);
           
            CustomerBL user = new CustomerBL(accnum, name, temppassword, income,   
            address, acctype, amount);
            try
            {
                if (user != null)
                {
                    CustomerDL.storeDataInFile(user, path);
                    CustomerDL.addIntoList(user);
                    MessageBox.Show("Customer Added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CustomerDL.readData(path);
                    clerkinterface m = new clerkinterface();
                    this.Close();
                    m.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void clerkop1_Load(object sender, EventArgs e)
        {

        }
    }
}
