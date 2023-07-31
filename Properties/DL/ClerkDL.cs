using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Staff;
using BA.Customer;
using System.IO;
using BA.Bank;

namespace BA.Clerk
{
    public class ClerkDL : StaffBL
    {
        public static bool DeleteRecordofCustomer(string accnum, string userName, string filepath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filepath);
                bool userRemoved = false;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(accnum) && lines[i].Contains(userName))
                    {
                        lines = lines.Where((val, idx) => idx != i).ToArray();
                        userRemoved = true;
                        break;
                    }
                }
                File.WriteAllLines(filepath, lines);
                return userRemoved;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating values: " + ex.Message);
            }
        }
        public static List<string> SearchCustomerbyaccnum(string accnum)
        {
            string filePath = "textfile.txt";
            List<string> records = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    if (values.Length >= 7 && (values[0]) == accnum)
                    {
                        string filteredLine = string.Join(",", values[0], values[1], values[3], values[4], values[5], values[6]);
                        records.Add(filteredLine);
                    }
                }
                return records;
            }
        }
    }
}
