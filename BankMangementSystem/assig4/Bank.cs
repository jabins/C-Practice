using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig4
{
    [Serializable]
    public class Bank
    {
       public static List<Bank> branches;
        public string name { get; set; }

        public Bank(string name)
        {
            this.name = name;
        }
        public static List<Bank> GetBranches()
        {
            branches = new List<Bank>();

            branches.Add(new Bank("RBC Royal Bank: 480 Dundas St E, Toronto, ON M5A 2C4"));
            branches.Add(new Bank("RBC Royal Bank:  382 Yonge St, Toronto, ON M5B 1S8"));
            //branches.Add(new Bank("Thomas David Morrison", "1836", "1837"));
            //branches.Add(new Bank("George Gurnett", "1837", "1838"));
            return branches;
        }
       
        public static void DelBranches(string items)
        {
            branches.Remove(new Bank(items));
            
        }
    }
}
