using BA.Customer;
using BA.Staff;
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
    public partial class customerlogin : Form
    {
        public customerlogin()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            if (name != null && password != null)
            {
                CustomerBL user = new CustomerBL(name, password);
                bool check = CustomerDL.isExists(user);
                if (check)
                {
                    customerinterface i = new customerinterface();
                    this.Close();
                    i.Show();
                }
                else
                {
                    MessageBox.Show("Login Error!!!");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }
    }
}
