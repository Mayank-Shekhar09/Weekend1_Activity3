using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCart2BL
{
    class PrivilegedCustomer : Customer
    {
        private CustomerCardType cardType;
        public CustomerCardType CardType { 
            get; 
            set; 
        }
        PrivilegedCustomer(string customerName, string address, DateTime dateOfBirth, string emailId, Enums.Gender gender, string password, CustomerCardType cardType) : base(customerName, address, dateOfBirth, emailId, gender, password)
        {
            this.cardType = cardType;
        }
    }
}
