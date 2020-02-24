using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jason_Choi_LINQ_Extension_Methods
{
    class Invoice
    {
        // Fields
        private int quantityValue;
        private decimal priceValue;
        
        // Auto-Properties
        public int PartNumber { get; set; }
        public string PartDescription { get; set; }

        // Constructor
        public Invoice(int partNumber, string partDescription, int quantity, decimal price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            Price = price;
        }

        // Properties - Not allow "quantity" and "price" values to be negative
        public int Quantity
        {
            get { return quantityValue; }
            set
            {
                if (value > 0)
                {
                    quantityValue = value;
                }
            }
        }
        public decimal Price
        {
            get { return priceValue; }
            set
            {
                if (value >= 0M)
                {
                    priceValue = value;
                }
            }
        }

        // Override Methods - ToString()
        public override string ToString()
        {
            return string.Format("{0,-5} {1,-20} {2,-5} {3,6:C}",
            PartNumber, PartDescription, Quantity, Price);
        }
    }
}
