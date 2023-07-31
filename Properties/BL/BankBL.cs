using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BA.Bank
{
    class BankBL
    {
        string name;
        string address;
        string branchcode;
        string openingtime;
        string closingtime;
        public BankBL(string name, string address, string branchcode, string openingtime, string closingtime)
        {
            this.name = name;
            this.address = address;
            this.branchcode = branchcode;
            this.openingtime = openingtime;
            this.closingtime = closingtime;
        }
        public static void UpdateBankDetails(BankBL b, string filepath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filepath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(',');
                    if (values.Length >= 4)
                    {
                        values[4] = b.name;
                        values[3] = b.address;
                        values[2] = b.branchcode;
                        values[1] = b.openingtime;
                        values[0] = b.closingtime;
                        string updatedLine = string.Join(",", values);
                        lines[i] = updatedLine;
                        break;
                    }
                }
                File.WriteAllLines(filepath, lines);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating values: " + ex.Message);
            }
        }
    }
}
