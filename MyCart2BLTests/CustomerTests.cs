using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCart2BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCart2BL.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void CustomerTest()
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Assert.AreNotEqual(customer2, customer1);
        }
    }
}