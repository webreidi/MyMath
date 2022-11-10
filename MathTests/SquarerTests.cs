using Microsoft.VisualStudio.TestTools.UnitTesting;
using myMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTests
{
    [TestClass]
    public class SquarerTests
    {

        [TestMethod]
        public void SquaringTester()
        {
            Squarer square = new();
            double input = 2.0;
            double expectedResult = input * input;
            Assert.AreEqual(expectedResult, square.Square(input), "Squaring a simple number");
        }

        [TestMethod]
        public void SquareValueRange()
        {
            // Create an instance to test.
            Squarer squarer = new();

            // Try a range of values.
            for (double expected = 1e-8; expected < 1e+8; expected *= 3.2)
            {
                SquarerTests.RooterOneValue(squarer, expected);
            }
            SquarerTests.RooterOneValue(squarer, 500);
        }

        private static void RooterOneValue(Squarer squarer, double expectedResult)
        {
            double input = Math.Sqrt(expectedResult);
            double actualResult = squarer.Square(input);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 1000, "Squaring test Value Range Test");
        }
    }
}
