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
    public partial class managerlogin : Form
    {
        public managerlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                if (textBox1.Text == "manager")
                {
                    managerinterface i = new managerinterface();
                    this.Close();
                    i.Show();
                }
                else
                {
                    MessageBox.Show("Login Error!!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            this.Close();
            a.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void managerlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
