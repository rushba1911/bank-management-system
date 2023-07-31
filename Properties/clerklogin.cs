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
    public partial class clerklogin : Form
    {
        public clerklogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            if (name != null && password != null)
            {
                StaffBL user = new StaffBL(name, password);
                bool check = StaffDL.isExists(user);
                if (check)
                {
                    clerkinterface i = new clerkinterface();
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
            admin a = new admin();
            this.Close();
            a.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
