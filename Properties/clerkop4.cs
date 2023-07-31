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
    public partial class clerkop4 : Form
    {
        public clerkop4()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Bank Name", "Bank Name");
            dataGridView1.Columns.Add("Bank Address", "Bank Address");
            dataGridView1.Columns.Add("Branch Code", "Branch Code");
            dataGridView1.Columns.Add("Opening Time", "Opening Time");
            dataGridView1.Columns.Add("Closing Time", "Closing Time");
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
            clerkinterface c = new clerkinterface();
            this.Close();
            c.Show();
        }

        private void clerkop4_Load(object sender, EventArgs e)
        {
            try
            {
                string filePath = "bankinfo.txt";
                List<string> records = StaffDL.ViewBankDetails(filePath);
                dataGridView1.Rows.Clear();
                foreach (string record in records)
                {
                    string[] values = record.Split(',');
                    dataGridView1.Rows.Add(values);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
