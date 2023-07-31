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
    public partial class updationinterface : Form
    {
        public updationinterface()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customerop6c op6c = new customerop6c();
            this.Hide();
            op6c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerop6a op6a = new customerop6a();
            this.Hide();
            op6a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customerinterface i = new customerinterface();
            this.Hide();
            i.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customerop6b op6b = new customerop6b();
            this.Hide();
            op6b.Show();
        }
    }
}
