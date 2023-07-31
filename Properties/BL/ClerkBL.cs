using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Staff;
using System.IO;

namespace BA.Clerk
{
    public class ClerkBL : StaffBL
    {
        public string newname;
        public string newpassword;

        public ClerkBL()
        {

        }

        public ClerkBL(string name, string newpassword)
        {
            this.name = name;
            this.newpassword = newpassword;
        }

        public static bool ChangePass(string name, string pass)
        {
            string filepath = "textfile1.txt";
            try
            {
                string[] lines = File.ReadAllLines(filepath);
                bool passwordUpdated = false;
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(',');
                    if (values.Length > 0 && values[0] == name)
                    {
                        values[1] = pass;
                        passwordUpdated = true;
                    }
                    string updatedLine = string.Join(",", values);
                    lines[i] = updatedLine;
                }
                File.WriteAllLines(filepath, lines);
                StaffDL.ReadData(filepath);
                return passwordUpdated;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating password: " + ex.Message);
            }
        }
    }
}
