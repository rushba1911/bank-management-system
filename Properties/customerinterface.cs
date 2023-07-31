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
    public partial class customerinterface : Form
    {
        public customerinterface()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            updationinterface u = new updationinterface();
            this.Hide();
            u.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            customerop1 op1 = new customerop1();
            this.Hide();
            op1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            customerop2 op2 = new customerop2();
            this.Hide();
            op2.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            customerop3 op3 = new customerop3();
            this.Hide();
            op3.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            customerop4 op4 = new customerop4();
            this.Hide();
            op4.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            customerop5 op5 = new customerop5();
            this.Hide();
            op5.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            customerop7 op7 = new customerop7();
            this.Hide();
            op7.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            customerlogin l = new customerlogin();
            this.Close();
            l.Show();
        }
    }
}
