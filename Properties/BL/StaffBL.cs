using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Staff
{
    public class StaffBL
    {
        public string name;
        public string password;
        public StaffBL(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public StaffBL(string password)
        {
            this.password = password;
        }
        public StaffBL()
        {

        }
    }
}
