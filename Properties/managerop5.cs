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
    public partial class managerop5 : Form
    {
        public managerop5()
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
            string path = "textfile1.txt";
            string name = textBox1.Text;
            string password = textBox2.Text;
            StaffBL user = new StaffBL(name, password);
            try
            {
                if (user != null)
                {
                    StaffDL.StoreDataInFile(user, path);
                    StaffDL.addIntoList(user);
                    MessageBox.Show("Clerk Account Added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StaffDL.ReadData(path);
                    managerinterface m = new managerinterface();
                    this.Close();
                    m.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
