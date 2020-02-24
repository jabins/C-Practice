using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


/*
[Requirements]

1. Build the Dental Payment System App using WPF. You can use appropriate layout controls.
2. If patient is Senior, then give 10% discount, if he/she is in category –Kids/Youth then 15% discount.
3. Add one combo box under Address textbox (drop down for Provinces – Alberta – HST 7%, Ontario- HST 13% and Quebec- HST 6%).
4. As per the selection of the province, Total Charges should be calculated accordingly.
*/

namespace Jason_Choi_Simple_Dental_Payment_System
{
    public partial class MainWindow : Window
    {
        // Fields
        public string name;
        public string address;
        public string province;
        public string ageCategory;
        public double taxRate;
        public double discount;
        public double price = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        // ComboBox Event Control - Province
        private void comboBoxProvince_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                ComboBoxItem item = comboBox.SelectedItem as ComboBoxItem;
                if (item != null)
                {
                    province = item.Content.ToString();
                }
            }
        }

        // Button Click Event Control - Calculate button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name = txtName.Text;
            address = txtAddress.Text;

            // CheckBox Condition Statement -  Dental Services
            if (checkBoxFlossing.IsChecked == true)
                price += 20;
            if (checkBoxFilling.IsChecked == true)
                price += 75;
            if (checkBoxRootCanal.IsChecked == true)
                price += 150;

            // ComboBox Condition Statement - Provinces
            if (province == "Alberta")
                taxRate = 1.07;
            if (province == "Ontario")
                taxRate = 1.13;
            if (province == "Quebec")
                taxRate = 1.06;

            // Radio Button Condition Statement - Age Categories
            if (radioSenior.IsChecked == true)
            {
                ageCategory = "Senior";
                discount = 0.10;
            }
            if (radioKidsYouth.IsChecked == true)
            {
                ageCategory = "Kids and Youth";
                discount = 0.15;
            }
            if (radioAdult.IsChecked == true)
            {
                ageCategory = "Adult";
            }

            // Display - MessageBox
            MessageBox.Show("[Patient Information] \n\n" +
                        "* Name: " + name + "\n" +
                        "* Address: " + address + "\n" +
                        "* Province: " + province + "\n" +
                        "* Age Category: " + ageCategory + "\n\n" +
                        "Totoal Price: $" + (price * taxRate * (1 - discount)).ToString()   // Calculate total price after applying a discount and tax rate
                        , "Results", MessageBoxButton.OK, MessageBoxImage.Information);

            // Shut Down application once price is calculated
            Application.Current.Shutdown();
        }
    }
}
