using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCart2BL
{
    public class EliteCustomer : Customer
    {
        private int ownedCoupons;
        public int OwnedCoupons { 
            get 
            { 
                return ownedCoupons; 
            } 
            set 
            { 
                ownedCoupons = value; 
            } 
        }
        public EliteCustomer(string customerName, string address, DateTime dateOfBirth, string emailId, Enums.Gender gender, string password, int ownedCoupon) : base(customerName, address, dateOfBirth, emailId, gender, password)
        {
            this.OwnedCoupons = ownedCoupons;
            if (OwnedCoupons > 0)
            {
                Console.WriteLine("Valid Owned Coupon");
            }
            else
            {
                Console.WriteLine("Entered value is invalid");
            }
           
        }
    }
}
