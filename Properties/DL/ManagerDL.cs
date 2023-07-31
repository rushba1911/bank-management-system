using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Staff;
using BA.Manager;
using BA.Bank;
using BA.Customer;
using System.IO;

namespace BA.Manager
{
    public class ManagerDL
    {
        public static bool DeleteClerkAcc(string userName, string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                bool clerkdeleted = false;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(userName))
                    {
                        lines = lines.Where((val, idx) => idx != i).ToArray();
                        clerkdeleted = true;
                        break;
                    }
                }
                File.WriteAllLines(filePath, lines);
                return clerkdeleted;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating values: " + ex.Message);
            }
        }
        public static List<string> FindAllRecords(string filePath)
        {
            List<string> records = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (values.Length >= 3)
                    {
                        string[] filteredValues = new string[values.Length - 1];
                        Array.Copy(values, 0, filteredValues, 0, 2);
                        Array.Copy(values, 3, filteredValues, 2, values.Length - 3);
                        string filteredLine = string.Join(",", filteredValues);
                        records.Add(filteredLine);
                    }
                }
            }
            return records;
        }
        public static List<string[]> ShowClerkDetails(string filePath)
        {
            List<string[]> records = new List<string[]>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    records.Add(values);
                }
            }
            return records;
        }
    }
}
