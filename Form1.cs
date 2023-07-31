using BA.Customer;
using BA.Staff;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = "textfile.txt";
            bool check = CustomerDL.readData(path);
            if (check)
            {
                MessageBox.Show("Data Loaded Successfully!!");
            }
            string path2 = "textfile1.txt";
            bool click = StaffDL.ReadData(path2);
            if (click)
            {
                MessageBox.Show("Data Loaded Successfully!!");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            customerlogin c = new customerlogin();
            this.Hide();
            c.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            this.Hide();
            a.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
