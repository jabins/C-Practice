using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig4
{
    public class Account
    {
        public static List<Account> accounts;
        public double balance;
        public string accountNumber { get; set; }
        

        public Account(string AccountNumber)
        {
            accountNumber = AccountNumber;
        }
        public static List<Account> GetAccounts()
        {
            accounts = new List<Account>();

            accounts.Add(new Account("Saving Account"));
            accounts.Add(new Account("Checking Account"));
            //branches.Add(new Bank("Thomas David Morrison", "1836", "1837"));
            //branches.Add(new Bank("George Gurnett", "1837", "1838"));
            return accounts;
        }
    }
}
