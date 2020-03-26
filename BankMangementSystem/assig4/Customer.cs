using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig4
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
    

        public Customer(string firstName, string lastName, Address address)
        {
            FirstName = firstName; LastName = lastName; Address = address;
        }
        public string GetKey()
        {
            return (FirstName);
        }

        public static List<Customer> GetCustomer()
        {
            List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer("Gina", "Caldwell", new Address("668", "", "E.Wood St", "Penetanguishene", "ON", "L9M K6Y", "705-527-8210")));
            //customers.Add(new Customer("Brenda", "Hopkins", new Address("703", "", "N. West Ave.", "Ste. Anne", "MB", "R5H T4T", "204-422-5293")));

            return customers;
        }
        public override string ToString()
        {
            return this.FirstName + "\t" + this.LastName + "\t" + this.Address.StreetNumber + "\t" + this.Address.StreetName + "\t"
                + this.Address.City + "\t" + this.Address.Province + "\t" + this.Address.PostalCode + "\t" + this.Address.PhoneNumber + "\t";
                ;
        }

    }
}
