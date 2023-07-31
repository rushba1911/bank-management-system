using BA.Manager;
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
    public partial class managerinterface : Form
    {
        public managerinterface()
        {
            InitializeComponent();
    }

        private void button4_Click(object sender, EventArgs e)
        {
            managerop4 op4 = new managerop4();
            this.Hide();
            op4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            managerop1 op1 = new managerop1();
            this.Hide();
            op1.Show();
        }

        private List<string[]> FindAllRecords(string filePath)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            managerop2 op2 = new managerop2();
            this.Hide();
            op2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            managerop3 op3 = new managerop3();
            this.Hide();
            op3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            managerop5 op5 = new managerop5();
            this.Hide();
            op5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            managerop6 op6 = new managerop6();
            this.Hide();
            op6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            admin a = new admin();
            this.Close();
            a.Show();
        }

        private void managerinterface_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            managerop7 op7 = new managerop7();
            this.Hide();
            op7.Show();
        }
    }
}
