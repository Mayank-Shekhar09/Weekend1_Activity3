using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCart2BL
{
    public class Customer
    {
        public enum CustomerCardType
        {
            silver,
            gold,
            platinum
        };
        public class Enums
        {
            public enum Gender
            {
                male,
                female,
                others
            };
        }
        private string address;
        public static int currentValueForCustomerId;
        private int customerId;
        private string customerName;
        private DateTime dateOfBirth;
        private string emailId;
        private Enums.Gender gender;
        private string password;
        public string Address {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        public int CustomerId {
            get
            {
                return this.customerId;
            }
            set
            {
                this.customerId = value;

            }
        }
        public string CustomerName {
            get
            {
                return this.customerName;
            }
            set
            {
                this.customerName = value;
            } 
        }
        public DateTime DateOfBirth { 
            get
            {
                return this.dateOfBirth;
            }
            set
            {
                this.dateOfBirth = value;
            }
        }
        public string EmailId {
            get
            {
               return this.emailId;
            }
            set
            {
                this.emailId = value;
            } 
        }
        public string Gender {
            get;

            set;
            
        }
        public string Password { 
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        static Customer()
        {
            currentValueForCustomerId = 1000;
        }
        public Customer()
        {
            customerId = currentValueForCustomerId;
            currentValueForCustomerId++;
            Console.WriteLine(customerId);
        }

        public Customer(string customerName, string address, DateTime dateOfBirth, string emailId, Enums.Gender gender, string password)
        {
            try
            {
                this.customerName = customerName;
                this.address = address;
                this.dateOfBirth = dateOfBirth;
                this.emailId = emailId;
                this.gender = gender;
                this.password = password;
            }
            catch(Exception e)
            {
                Console.WriteLine("Enter correct Input.");
            }
        }
    }
}
