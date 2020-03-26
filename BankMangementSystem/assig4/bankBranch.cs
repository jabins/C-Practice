using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace assig4
{
    public partial class BankBranch : Form
    {
        List<Bank> branch = new List<Bank>();
        int selectRow;
        public BankBranch()
        {
            InitializeComponent();
            dataGridView1.DataSource = branch;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtBranches.Text!="")
            {
                branch.Add(new Bank(txtBranches.Text));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = branch;
                MessageBox.Show("Branch has been added Successfully!");
            }
            else
            {
                MessageBox.Show("Please Enter a Name!");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            branch = Bank.GetBranches();
            dataGridView1.DataSource = branch;
           
                //string[] fields = null;
                //TextReader reader = new StreamReader("branches.xml");
                //XmlSerializer serializer = new XmlSerializer(typeof(List<Branch>));
                //List<Branch> branches = (List<Branch>)serializer.Deserialize(reader);

            //    string line = reader.ReadLine();
            //    while (line != null)
            //    {
            //        fields = line.Split();
            //        //Address address = new Address(fields[1], fields[2], fields[3], fields[4], fields[5], fields[6], fields[7]);
            //        Branch b = new Branch(fields[0]);
            //        branch.AddBranch(branch);
            //        line = reader.ReadLine();
            //    }
            //    for (int i = 0; i < newBank.branches.Count; i++)
            //    {
            //        listBox_Branches.Items.Add(newBank.branches[i].name);
            //    }
            //    reader.Close();
            //}
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("If you delete this branches, you won't be able to recover it. Do you want to delete it ?", "Delete Branch", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                branch.Remove(branch[index]);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = branch;
            }        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //Form2 form = assembly.CreateInstance(txtBranches.Text) as Form2;
            //form.Show();
            //Form2 f = null;
            //switch(para)
            //{
            //    case txtBranches.Text: f = new Form2();break
            //}
            CustomerRegistration frm = new CustomerRegistration();
            frm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectRow];
            txtBranches.Text = row.Cells[0].Value.ToString();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to update it ?", "Update Branch", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                DataGridViewRow newDataRow = dataGridView1.Rows[selectRow];
                newDataRow.Cells[0].Value = txtBranches.Text;
            }

        }
    }
}
