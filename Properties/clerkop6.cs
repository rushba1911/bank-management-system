using BA.Clerk;
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
    public partial class clerkop6 : Form
    {
        public clerkop6()
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
            string name = textBox2.Text;
            string password = textBox1.Text;
            try
            {
                bool check = ClerkBL.ChangePass(name, password);
                if (check)
                {
                    MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clerkinterface m = new clerkinterface();
                    this.Close();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("The Clerk Name you provided does not exist in this System.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
