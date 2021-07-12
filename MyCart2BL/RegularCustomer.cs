using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCart2BL
{
    public class RegularCustomer : Customer
    {
        private double discountPercentage;
        public double DiscountPercentage { 
            get; 
            set; 
        }
        public RegularCustomer(string customerName, string address, DateTime dateOfBirth, string emailId, Enums.Gender gender, string password) : base(customerName, address, dateOfBirth, emailId, gender, password)
        {
            if (discountPercentage > 0)
            {
                discountPercentage = 2;
            }
            else
            {
                Console.WriteLine("Entered value is invalid");
            }
        }
    }
}
