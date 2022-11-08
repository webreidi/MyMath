using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMath;

namespace MathTests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void BasicRooterTest()
        {
            // Create an instance to test:
            Rooter rooter = new Rooter();
            // Define a test input and output value:
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;
            // Run the method under test:
            double actualResult = rooter.SquareRoot(input);
            // Verify the result:
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }

        [TestMethod]
        public void RooterValueRange()
        {
            // Create an instance to test.
            Rooter rooter = new Rooter();

            // Try a range of values.
            for (double expected = 1e-8; expected < 1e+8; expected *= 3.2)
            {
                RooterOneValue(rooter, expected);
            }
        }

        [TestMethod]
        private void RooterOneValue(Rooter rooter, double expectedResult)
        {
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 1000);
        }

        [TestMethod]
        public void RooterTestNegativeInputx()
        {
            Rooter rooter = new Rooter();
            try
            {
                rooter.SquareRoot(-10);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void SquaringTester()
        {
            Squarer square = new Squarer();
            double input = 2.0;
            double expectedResult = input * input;
            Assert.AreEqual(expectedResult, square.Square(input));
        }

        [TestMethod]
        public void TestAbsoluteValueNegative() 
        {
            var maths = new WendysMath();
            double input = -27.58;
            double expectedResult = 27.58;
            Assert.AreEqual(expectedResult, maths.AbsoluteValue(input));
        }

        [TestMethod]
        public void TestAbsoluteValuePositive()
        {
            var maths = new WendysMath();
            double input = 27.58;
            Assert.AreEqual(input, maths.AbsoluteValue(input));            
        }

        [TestMethod]
        public void TestAbsoluteValueZero()
        {
            var maths = new WendysMath();
            double input = 0;
            Assert.AreEqual(input, maths.AbsoluteValue(input));            
        }

        [TestMethod]
        public void TestRoundUp()
        {
            var maths = new WendysMath();
            double input = 27.58;
            Assert.AreEqual(28, maths.Rounder(input));
        }

        [TestMethod]
        public void TestRoundDown()
        {
            var maths = new WendysMath();
            double input = 27.48;
            Assert.AreEqual(27, maths.Rounder(input));
        }

        [TestMethod]
        public void TestRounding()
        {
            var maths = new WendysMath();
            double input = 27.5;
            Assert.AreEqual(28, maths.Rounder(input));
        }

        [TestMethod]
        public void TestMaxer()
        {
            var maths = new WendysMath();
            double a = 27.48;
            double b = 27.58;
            Assert.AreEqual(b, maths.Maxer(a,b));
        }

        [TestMethod]
        public void TestMinner()
        {
            var maths = new WendysMath();
            double a = 27.48;
            double b = 27.58;
            Assert.AreEqual(a, maths.Minner(a,b));
        }

        [TestMethod]
        public void TestMaxerAgain()
        {
            var maths = new WendysMath();
            double b = 27.48;
            double a = 27.58;
            Assert.AreEqual(a, maths.Maxer(a,b));
        }

        [TestMethod]
                public void TestMinnerAgain()
        {
            var maths = new WendysMath();
            double b = 27.48;
            double a = 27.58;
            Assert.AreEqual(b, maths.Minner(a,b));
        }

        [TestMethod]
        public void TestMaxerEqual()
        {
            var maths = new WendysMath();
            double a = 27.48;
            double b = 27.48;
            Assert.AreEqual(a, maths.Maxer(a,b));
        }

        [TestMethod]
        public void TestMinnerEqual()
        {
            var maths = new WendysMath();
            double a = 27.48;
            double b = 27.48;
            Assert.AreEqual(a, maths.Minner(a,b));
        }

    }
}