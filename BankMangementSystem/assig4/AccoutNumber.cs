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
    public partial class AccoutNumber : Form
    {
        List<Account> account = new List<Account>();
        DataTable accountTable = new DataTable();
        int selectRow;
        public AccoutNumber()
        {
            InitializeComponent();
            //dataGridView1.DataSource = account;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("If you delete this branches, you won't be able to recover it. Do you want to delete it ?", "Delete Branch", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                account.Remove(account[index]);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = account;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text != "")
            {
                account.Add(new Account(txtAccount.Text));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = account;
                MessageBox.Show("Account has been added Successfully!");
            }
            else
            {
                MessageBox.Show("Please Enter an account!");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //account=Account.GetAccounts();
            //dataGridView1.DataSource = account;
            accountTable.Columns.Add("Account Number", typeof(string));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to update it ?", "Update Branch", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                DataGridViewRow updatedRow = dataGridView1.Rows[selectRow];
                updatedRow.Cells[0].Value = txtAccount.Text;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectRow];
            txtAccount.Text = row.Cells[0].Value.ToString();
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            DepositWithdrawal frm = new DepositWithdrawal();
            frm.accountLabel.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
        }
    }
}
