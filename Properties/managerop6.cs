using BA.Manager;
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
    public partial class managerop6 : Form
    {
        public managerop6()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            managerinterface m = new managerinterface();
            this.Close();
            m.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string filepath = "textfile1.txt";
            string name = textBox1.Text;
            try
            {
                bool check = ManagerDL.DeleteClerkAcc(name, filepath);
                if (check)
                {
                    MessageBox.Show("Clerk account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StaffDL.ReadData(filepath);
                    managerinterface m = new managerinterface();
                    this.Close();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("The Name of Clerk you provided does not exist in this System.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
