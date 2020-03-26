using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assig4
{
    public partial class DepositWithdrawal : Form
    {
        List<Account> accounts = new List<Account>();
        public DepositWithdrawal()
        {
            InitializeComponent();
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            double deposit = Convert.ToDouble(depositBox.Text);
            double balance = Convert.ToDouble(balanceLabel.Text);

            balance += deposit;

            balanceLabel.Text = balance.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void withdrawalBtn_Click_1(object sender, EventArgs e)
        {
            double withdrawal = Convert.ToDouble(withdrawalBox.Text);
            double balance = Convert.ToDouble(balanceLabel.Text);

            balance -= withdrawal;

            balanceLabel.Text = balance.ToString();
        }
    }
}
