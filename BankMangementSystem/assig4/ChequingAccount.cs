using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig4
{
    public class ChequingAccount : Account
    {
        //Properties
        public double MonthlyFee { get; set; }

        //Constructors
        public ChequingAccount(string accountNumber, double monthlyFee) : base(accountNumber)
        {
            this.accountNumber = accountNumber;
            MonthlyFee = monthlyFee;
        }
    }
}
