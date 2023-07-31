using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Customer
{
    public class CustomerBL
    {
        public string accnum;
        public string name;
        public string password;
        public string income;
        public string address;
        public string acctype;
        public double amount;
        public CustomerBL(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public CustomerBL(string accnum, string name, string password, string income, 
        string address, string acctype, double amount)
        {
            this.accnum = accnum;
            this.name = name;
            this.password = password;
            this.income = income;
            this.address = address;
            this.acctype = acctype;
            this.amount = amount;
        }
        public CustomerBL()
        {

        }
    }
}
