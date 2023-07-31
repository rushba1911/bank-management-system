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
    public partial class managerop2 : Form
    {
        public managerop2()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("AccountNumber", "Account Number");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Feedback", "Feedback");
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11);
            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            managerinterface m = new managerinterface();
            this.Close();
            m.Show();
        }
        private void managerop2_Load(object sender, EventArgs e)
        {
            try
            {
                string filePath = "feedback.txt";
                List<string[]> records = StaffDL.ShowFeedbacks(filePath);
                dataGridView1.Rows.Clear();
                foreach (var values in records)
                {
                    if (values.Length >= 1)
                    {
                        dataGridView1.Rows.Add(values);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
