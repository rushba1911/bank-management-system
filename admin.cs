using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            managerlogin m = new managerlogin();
            this.Hide();
            m.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clerklogin c = new clerklogin();
            this.Hide();
            c.Show();
        }
    }
}
