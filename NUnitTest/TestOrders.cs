﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_training.NUnitTest
{
    internal class TestOrders
    {




        [Test,Order(1)]
        public void login()
        {
            Console.WriteLine("logging into application");

        }

        [Test,Order(2)]
        public void product()
        {
            Console.WriteLine("selecting the product");

        }
        [Test,Order(3)]
        public void addtoCart()
        {
            Console.WriteLine("product added to the cart");

        }
    }
}
