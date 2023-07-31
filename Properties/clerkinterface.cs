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
    public partial class clerkinterface : Form
    {
        public clerkinterface()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clerkop1 op1 = new clerkop1();
            this.Hide();
            op1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clerkop2 op2 = new clerkop2();
            this.Hide();
            op2.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clerkop3 op3 = new clerkop3();
            this.Hide();
            op3.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            clerkop4 op4 = new clerkop4();
            this.Hide();
            op4.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            clerkop5 op5 = new clerkop5();
            this.Hide();
            op5.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            clerkop6 op6 = new clerkop6();
            this.Hide();
            op6.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            clerklogin c = new clerklogin();
            this.Close();
            c.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
