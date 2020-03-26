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
    public partial class CustomerRegistration : Form
    {
        List<Customer> customers = new List<Customer>();
        Dictionary<string, Customer> dictionary;
        public CustomerRegistration()
        {
            InitializeComponent();
            ListItem();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {

            //foreach (string s in CustomerName.SelectedItems.OfType<string>().ToList())
            //    CustomerName.Items.Remove(s);
            var result = MessageBox.Show("If you delete this information, you won't be able  recover it. Do you want to delete it ?", "Delete Customer Information", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (CustomerName.Items.Count > 0)
                {
                    CustomerName.Items.RemoveAt(CustomerName.SelectedIndex);
                }
            }

        }
        private void Customer_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                txtFirst.Text    = dictionary[CustomerName.SelectedItem.ToString()].FirstName;
                txtLast.Text     = dictionary[CustomerName.SelectedItem.ToString()].LastName;
                txtStreetNO.Text = dictionary[CustomerName.SelectedItem.ToString()].Address.StreetNumber;
                txtAppt.Text     = dictionary[CustomerName.SelectedItem.ToString()].Address.ApartmentNumber;
                txtStreetNm.Text = dictionary[CustomerName.SelectedItem.ToString()].Address.StreetName;
                txtCity.Text     = dictionary[CustomerName.SelectedItem.ToString()].Address.City;
                txtProvi.Text    = dictionary[CustomerName.SelectedItem.ToString()].Address.Province;
                txtPost.Text     = dictionary[CustomerName.SelectedItem.ToString()].Address.PostalCode;
                txtPhone.Text    = dictionary[CustomerName.SelectedItem.ToString()].Address.PhoneNumber;
            }
            catch
            {

            }
            //Customer c = (Customer)CustomerName.SelectedItem;
            Customer c = CustomerName.SelectedItem as Customer;
            if (c == null) return;
            //btnDel.Enabled = true;
            btnUpdate.Enabled = true;
             txtFirst.Text=c.FirstName;
            txtLast.Text=c.LastName;
            txtStreetNO.Text = c.Address.StreetNumber;
            txtStreetNm.Text = c.Address.StreetName;
            txtAppt.Text = c.Address.ApartmentNumber;
            txtCity.Text=c.Address.City;
            txtProvi.Text=c.Address.Province;
            txtPost.Text=c.Address.PostalCode;
            txtPhone.Text=c.Address.PhoneNumber;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccoutNumber frm = new AccoutNumber();
            frm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //int i = CustomerName.SelectedIndex;
            //CustomerName.Items.RemoveAt(i);
            //CustomerName.Items.Insert(i, txtFirst.Text);
            if (txtFirst.Text != "" && txtLast.Text != "" && txtPhone.Text != "" && txtStreetNO.Text != "" && 
                txtStreetNm.Text != "" && txtCity.Text != "" && txtCity.Text != "" && txtProvi.Text != "")
            {
                Customer ct = new Customer(txtFirst.Text, txtLast.Text, new Address(txtStreetNO.Text, txtAppt.Text, txtStreetNm.Text,
               txtCity.Text, txtProvi.Text, txtPost.Text, txtPhone.Text));
                CustomerName.Items.Add(ct);
                MessageBox.Show("Customer has been added Successfully!");
                ClearText();
            }
            else
            {
                MessageBox.Show("Customer Information cannot be blank! Please fill out the entire form!");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        { var result = MessageBox.Show("Do you want to update it ?", "Update Information", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //int i =CustomerName.SelectedIndex;
                //CustomerName.Items.RemoveAt(i);
                //CustomerName.Items.Insert(i,txtFirst.Text);
                Customer selected = CustomerName.SelectedItem as Customer;
                //Customer selected = (Customer)CustomerName.SelectedItem;
                int index = CustomerName.Items.IndexOf(selected);
                selected.FirstName = txtFirst.Text;
                selected.LastName = txtLast.Text;
                selected.Address.StreetNumber = txtStreetNO.Text;
                selected.Address.ApartmentNumber = txtAppt.Text;
                selected.Address.StreetName = txtStreetNm.Text;
                selected.Address.City = txtCity.Text;
                selected.Address.Province = txtProvi.Text;
                selected.Address.PostalCode = txtPost.Text;
                selected.Address.PhoneNumber = txtPhone.Text;
                CustomerName.Items.RemoveAt(index);
                CustomerName.Items.Insert(index, selected);
                CustomerName.SelectedItem = selected;
            }
        }
        public void ListItem()
        {
            dictionary = new Dictionary<string, Customer>();

            foreach (Customer item in Customer.GetCustomer())
            {
                dictionary.Add(item.GetKey(), item);
                CustomerName.Items.Add(item.GetKey());
            }
        }
        public void ClearText()
        {
            txtAppt.Clear();
            txtAppt.Focus();
            txtCity.Clear();
            txtCity.Focus();
            txtFirst.Clear();
            txtFirst.Focus();
            txtLast.Clear();
            txtLast.Focus();
            txtPhone.Clear();
            txtPhone.Focus();
            txtPost.Clear();
            txtPost.Focus();
            txtProvi.Clear();
            txtProvi.Focus();
            txtStreetNm.Clear();
            txtStreetNm.Focus();
            txtStreetNO.Clear();
            txtStreetNO.Focus();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
