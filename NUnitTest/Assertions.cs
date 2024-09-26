//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace NUnitSeleniumC_training.NUnitTest
//{
//    internal class Assertions
//    {
//        [Test]
//        public void TestAssertion()
//        {
//            string actual = "google";
//            string expected = "yahoo";
//            /*if (actual == expected)
//            {
//                Console.WriteLine("results are matching");
//            }
//            else
//            {
//                Console.WriteLine("results are not equal");
//            }*/

//        //assert equal
//        Assert.AreEqual(actual,expected);
//        Assert.AreNotEqual(actual,expected);

        
//        //assert that
//        Assert.That(actual, Is.EqualTo(expected));
//        Assert.That(actual,Is.Not.EqualTo(expected));

//        //assert for strings ignore case
//        Assert.That(actual,Is.EqualTo(expected).IgnoreCase);

//        //substring presence
//        Assert.That(actual,Does.Contain("def").IgnoreCase);
//        Assert.That(actual, Does.Not.Contain("def").IgnoreCase);

//        //empty constraints
//        Assert.IsEmpty(actual);
//        Assert.That(actual,Is.Empty);
//        Assert.IsTrue(actual.Equals(expected));
//        Assert.IsNull(actual);
//        Assert.IsNotNull(actual);

//        //collection constraints
//        int[] array=new int[] {1,2,3};

//        //not null
//        Assert.NotNull(array);

//        //greater than
//        Assert.That(array, Is.All.GreaterThan(0));

//        //empty
//        Assert.That(array, Is.Empty);
//        Assert.That(array, Is.Not.Empty);






//        }

//    }
//}
