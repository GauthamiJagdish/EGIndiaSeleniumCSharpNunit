using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_training.NUnitTest
{
    internal class UnitTestCalculatingwithsetupteardown
    {

        public Calculator cl;

        [SetUp]
        public void setup()
        {
            cl = new Calculator();
            Console.WriteLine("executing the setup");
        }

        [Test]
        public void TestAdd()
        {

            int result = cl.Add(2, 3);
            int result1 = cl.Add(3, -4);

            //Assertion on NUnit to compare the expected result

            Assert.AreEqual(5, result);

            Assert.AreEqual(-1, result1);

        }

        [Test]
        public void TestSub()
        {

            int result = cl.Sub(9, 4);
            int result1 = cl.Sub(-9, 4);

            //Assertion on NUnit to compare the expected result

            Assert.AreEqual(5, result);

            Assert.AreEqual(-13, result1);

        }

        [TearDown]
        public void Teardown()
        {
            Console.WriteLine("all the unit test or the calculator functionality are executed");
        }



    }
}

