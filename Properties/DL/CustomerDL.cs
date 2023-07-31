using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Bank;

namespace BA.Customer
{
    public class CustomerDL
    {
        public static List<CustomerBL> signList = new List<CustomerBL>();
        public static void addIntoList(CustomerBL c)
        {
            signList.Add(c);
        }
        public static bool isExists(CustomerBL c)
        {
            foreach (CustomerBL storeUser in signList)
            {
                if (c.name == storeUser.name && c.password == storeUser.password)
                {
                    return true;
                }
            }
            return false;

        }
        public static string parseData(string record, int field)
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
        public static bool readData(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string accnum = parseData(record, 1);
                    string name = parseData(record, 2);
                    string password = parseData(record, 3);
                    string income = parseData(record, 4);
                    string address = parseData(record, 5);
                    string acctype = parseData(record, 6);
                    string amount = parseData(record, 7);
                    CustomerBL user = new CustomerBL(name, password);
                    CustomerDL.addIntoList(user);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
        public static void storeDataInFile(CustomerBL user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.accnum + "," + user.name + "," + user.password + "," + user.income + "," + user.address + "," + user.acctype + "," + user.amount);
            file.Flush();
            file.Close();
        }
        public static bool TakeFeedback(string accnum, string name, string feedback)
        {
            string filePath = "feedback.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(accnum + "," + name + "," + feedback);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Your Feedback is not Submitted due to some unknown error: " + ex.Message);
            }
        }
        public static bool DepositMoney(string accnum, double money)
        {
            string filePath = "textfile.txt";
            string[] lines = File.ReadAllLines(filePath);
            bool depositSuccessful = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                if (values.Length >= 7 && values[0] == accnum)
                {
                    double oldMoney;
                    try
                    {
                        if (double.TryParse(values[6], out oldMoney))
                        {
                            double newMoney = oldMoney + money;
                            values[6] = newMoney.ToString();
                            depositSuccessful = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred while Depositing amount: " + ex.Message);
                    }
                }
                string updatedLine = string.Join(",", values);
                lines[i] = updatedLine;
            }
            File.WriteAllLines(filePath, lines);
            CustomerDL.readData(filePath);
            return depositSuccessful;
        }
        public static bool WithdrawMoney(string accnum, double money)
        {
            string filePath = "textfile.txt";
            string[] lines = File.ReadAllLines(filePath);
            bool withdrawalSuccessful = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                if (values.Length >= 7 && values[0] == accnum)
                {
                    double oldBalance;
                    try
                    {
                        if (double.TryParse(values[6], out oldBalance))
                        {
                            double newBalance = oldBalance - money;
                            if (newBalance >= 0)
                            {
                                values[6] = newBalance.ToString();
                                withdrawalSuccessful = true;
                            }
                            else
                            {
                                throw new Exception("You have Insufficient Balance");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred while withdrawing amount: " + ex.Message);
                    }
                }
                string updatedLine = string.Join(",", values);
                lines[i] = updatedLine;
            }
            File.WriteAllLines(filePath, lines);
            CustomerDL.readData(filePath);
            return withdrawalSuccessful;
        }
        public static bool ChangePass(string accnum, string updpass)
        {
            string filePath = "textfile.txt";
            string[] lines = File.ReadAllLines(filePath);
            bool updated = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                if (values.Length >= 7 && values[0] == accnum)
                {
                    values[2] = updpass;
                    updated = true;
                }
                string updatedLine = string.Join(",", values);
                lines[i] = updatedLine;
            }
            File.WriteAllLines(filePath, lines);
            readData(filePath);
            return updated;
        }
        public static bool DeleteAccount(string accnum, string userName, string password)
        {
            string filePath = "textfile.txt";
            string[] lines = File.ReadAllLines(filePath);
            bool lineDeleted = false;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(accnum) && lines[i].Contains(userName) && lines[i].Contains(password))
                {
                    lines = lines.Where((val, idx) => idx != i).ToArray();
                    lineDeleted = true;
                    break;
                }
            }
            if (lineDeleted)
            {
                File.WriteAllLines(filePath, lines);
                readData(filePath);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Updatename(string accnum, string name)
        {
            string filePath = "textfile.txt";
            string[] lines = File.ReadAllLines(filePath);
            bool updated = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                if (values.Length >= 7 && values[0] == accnum)
                {
                    values[1] = name;
                    updated = true;
                }
                string updatedLine = string.Join(",", values);
                lines[i] = updatedLine;
            }
            File.WriteAllLines(filePath, lines);
            readData(filePath);
            return updated;
        }
        public static bool UpdateAddress(string accnum, string address)
        {
            string filePath = "textfile.txt";
            string[] lines = File.ReadAllLines(filePath);
            bool updated = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                if (values.Length >= 7 && values[0] == accnum)
                {
                    values[4] = address;
                    updated = true;
                }

                string updatedLine = string.Join(",", values);
                lines[i] = updatedLine;
            }
            File.WriteAllLines(filePath, lines);
            readData(filePath);
            return updated;
        }
        public static bool UpdateSourceOfIncome(string accnum, string income)
        {
            string filePath = "textfile.txt";
            string[] lines = File.ReadAllLines(filePath);
            bool updated = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                if (values.Length >= 7 && values[0] == accnum)
                {
                    values[3] = income;
                    updated = true;
                }

                string updatedLine = string.Join(",", values);
                lines[i] = updatedLine;
            }
            File.WriteAllLines(filePath, lines);
            readData(filePath);
            return updated;
        }
        public static List<string> ReadCustomerRecord(string filePath, string accnum)
        {
            List<string> records = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (values.Length >= 7 && (values[0]) == accnum)
                    {
                        records.Add(line);
                        return records;
                    }
                    else
                    {
                        throw new Exception("The Account Number you have provided does not exist in this System.");
                    }
                }
            }
            return null;
        }
    }
}
