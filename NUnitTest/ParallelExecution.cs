using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_training.NUnitTest
{
    [Parallelizable(ParallelScope.All)]
    internal class ParallelExecution
    {

        [Test]
        public void login()
        {
            Console.WriteLine("logging into application");

        }

        [Test]
        public void product()
        {
            Console.WriteLine("selecting the product");

        }
        [Test]
        public void addtoCart()
        {
            Console.WriteLine("product added to the cart");
        }
    }
}
