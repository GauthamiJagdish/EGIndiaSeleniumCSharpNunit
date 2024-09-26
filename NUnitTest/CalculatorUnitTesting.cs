using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_training.NUnitTest
{
    internal class CalculatorUnitTesting
    {
        Calculator cl = new Calculator();

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

        [Test]
        public void TestMul()
        {

            int result = cl.Mul(3, 4);
            int result1 = cl.Mul(1, 5);

            //Assertion on NUnit to compare the expected result

            Assert.AreEqual(12, result);

            Assert.AreEqual(5, result1);

        }

        [Test]
        public void TestDiv()
        {

            int result = cl.Div(12, 4);
            int result1 = cl.Div(10, 5);

            //Assertion on NUnit to compare the expected result

            Assert.AreEqual(3, result);

            Assert.AreEqual(2, result1);

        }
    }
}
