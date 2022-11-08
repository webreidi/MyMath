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
    class SquarerTests
    {

        [TestMethod]
        public void SquaringTester()
        {
            Squarer square = new Squarer();
            double input = 2.0;
            double expectedResult = input * input;
            Assert.AreEqual(expectedResult, square.Square(input));
        }
    }
}
