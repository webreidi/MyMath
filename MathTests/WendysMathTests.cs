using Microsoft.VisualStudio.TestTools.UnitTesting;
using myMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathTests
{
    [TestClass]
    public class WendysMathTests
    {
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
            Assert.AreEqual(b, maths.Maxer(a, b));
        }

        [TestMethod]
        public void TestMinner()
        {
            var maths = new WendysMath();
            double a = 27.48;
            double b = 27.58;
            Assert.AreEqual(a, maths.Minner(a, b));
        }

        [TestMethod]
        public void TestMaxerAgain()
        {
            var maths = new WendysMath();
            double b = 27.48;
            double a = 27.58;
            Assert.AreEqual(a, maths.Maxer(a, b));
        }

        [TestMethod]
        public void TestMinnerAgain()
        {
            var maths = new WendysMath();
            double b = 27.48;
            double a = 27.58;
            Assert.AreEqual(b, maths.Minner(a, b));
        }

        [TestMethod]
        public void TestMaxerEqual()
        {
            var maths = new WendysMath();
            double a = 27.48;
            double b = 27.48;
            Assert.AreEqual(a, maths.Maxer(a, b));
        }

        [TestMethod]
        public void TestMinnerEqual()
        {
            var maths = new WendysMath();
            double a = 27.48;
            double b = 27.48;
            Assert.AreEqual(a, maths.Minner(a, b));
        }

        [TestMethod]
        public void TestPowerNegative()
        {
            var maths = new WendysMath();
            double a = 2;
            int b = -3;
            Assert.AreEqual(0.125, maths.Power(a, b));
        }

        [TestMethod]
        public void TestPower()
        {
            var maths = new WendysMath();
            for (int i = 0; i < 10; i++)
            {
                for (double b = -10; b < 10; b++)
                {
                    double pow = Math.Pow(b, i);
                    String msg = "Power Test where the base is " + b + " and the exponent is " + i + " giving an answer of " + pow;
                    Assert.AreEqual(pow, maths.Power(b, i), msg);
                }
            }
            
        }
        
        [TestMethod]
        public void TestPowerZero()
        {
            var maths = new WendysMath();
            double a = 2;
            int b = 0;
            Assert.AreEqual(1, maths.Power(a, b));
        }

        [TestMethod]
        public void TestFloorer()
        {
            var maths = new WendysMath();
            double a = 27.58;
            Assert.AreEqual(27, maths.Floorer(a));
        }

        [TestMethod]
        public void TestFloorZero()
        {
          var maths = new WendysMath();
                double a = 0;
                Assert.AreEqual(0, maths.Floorer(a));
            }

        [TestMethod]
        public void TestCeilinger()
        {
            var maths = new WendysMath();
            double a = 27.58;
            Assert.AreEqual(28, maths.Ceilinger(a));
        }
    }
}

