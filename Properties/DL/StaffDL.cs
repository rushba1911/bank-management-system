using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BA.Manager;
using BA.Customer;

namespace BA.Staff
{
    class StaffDL
    {
        public static List<StaffBL> signList = new List<StaffBL>();
        public static void addIntoList(StaffBL s)
        {
            signList.Add(s);
        }
        public static StaffBL IsExists(StaffBL s)
        {
            foreach (StaffBL storeUser in signList)
            {
                if (s.name == storeUser.name && s.password == storeUser.password)
                {
                    return storeUser;
                }
            }
            return null;
        }
        public static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        internal static bool isExists(CustomerBL user)
        {
            throw new NotImplementedException();
        }
        public static bool ReadData(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string name = ParseData(record, 1);
                    string password = ParseData(record, 2);
                    StaffBL user = new StaffBL(name, password);
                    addIntoList(user);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
        public static void StoreDataInFile(StaffBL user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.name + "," + user.password);
            file.Flush();
            file.Close();
        }
        public static bool isExists(StaffBL c)
        {
            foreach (StaffBL storeUser in signList)
            {
                if (c.name == storeUser.name && c.password == storeUser.password)
                {
                    return true;
                }
            }
            return false;
        }
        public static List<string[]> ShowFeedbacks(string filePath)
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
        public static List<string> ViewBankDetails(string filePath)
        {
            List<string> records = new List<string>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    records.Add(line);
                }
            }
            return records;
        }
    }
}
