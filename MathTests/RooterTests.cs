﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using myMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTests
{
    [TestClass]
    public class RooterTests
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
                Assert.IsTrue(true, "Caught exception for - square root");
                return;
            }
            Assert.Fail();
        }


    }
}