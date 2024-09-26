using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_training.NUnitTest
{
    [SetUpFixture]
    internal class baseclass
    {
        [OneTimeSetUp]
        public void dbconnectionopen()
        {
            TestContext.Progress.WriteLine("opening the dbconnection");
        }

        [OneTimeTearDown]
        public void dbconnectionclose()
        {
            TestContext.Progress.WriteLine("closing the dbconnection");
        }



    }
}
