using Microsoft.VisualStudio.TestTools.UnitTesting;
using myMath;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            WendysMath maths = new();
            Random rand = new();
            double input = -rand.NextDouble();
            double expectedResult = Math.Abs(input);
            Console.WriteLine("Input value is " + input);
            Assert.AreEqual(expectedResult, maths.AbsoluteValue(input));
        }

        [TestMethod]
        public void TestAbsoluteValuePositive()
        {
            WendysMath maths = new();
            Random rand = new();
            double input = rand.NextDouble();
            Console.WriteLine("Input value is " + input);
            Assert.AreEqual(input, maths.AbsoluteValue(input));
        }

        [TestMethod]
        public void TestAbsoluteValueZero()
        {
            WendysMath maths = new();
            double input = 0;
            Assert.AreEqual(input, maths.AbsoluteValue(input));
        }

        [TestMethod]
        public void TestRounding()
        {
            WendysMath maths = new();
            Random rand = new();
            double input = rand.NextDouble();
            double expectedResult = Math.Round(input);
            Console.WriteLine("Input value is " + input);
            Assert.AreEqual(expectedResult, maths.Rounder(input));
        }

        [TestMethod]
        public void TestRounder()
        {
            WendysMath maths = new();
            Random rand = new();
            for (int a = 1; a < 10; a++)
            {
                double input = rand.NextInt64() + rand.NextDouble();
                Console.WriteLine("Input value is " + input);
                if ((double)Convert.ToDecimal(input) >= 0.5)
                {
                    double expectedResult = Math.Ceiling(input);
                    Assert.AreEqual(expectedResult, maths.Rounder(input));
                }
                else
                {
                    double expectedResult = Math.Floor(input);
                    Assert.AreEqual(expectedResult, maths.Rounder(input));
                }
            }
        }

        [TestMethod]
        public void TestMaxer()
        {
            WendysMath maths = new();
            Random rand = new();
            for (int j = 1; j < 10; j++)
            {
                double a = rand.NextInt64() + rand.NextDouble();
                double b = rand.NextInt64() + rand.NextDouble();
                double expectedResult = Math.Max(a, b);
                Console.WriteLine("Input value is " + a + " and " + b);
                Assert.AreEqual(expectedResult, maths.Maxer(a, b));
            }
        }

        [TestMethod]
        public void TestMinner()
        {
            WendysMath maths = new();
            Random rand = new();
            for (int j=1; j<10; j++)
            {
                double a = rand.NextInt64() + rand.NextDouble();
                double b = rand.NextInt64() + rand.NextDouble();
                double expectedResult = Math.Min(a, b);
                Console.WriteLine("Input value is " + a + " and " + b);
                Assert.AreEqual(expectedResult, maths.Minner(a, b));
            }            
        }

        [TestMethod]
        public void TestMaxerEqual()
        {
            WendysMath maths = new();
            Random rand = new();
            for (int j = 0; j < 10; j++)
            {
                double a = rand.NextInt64() + rand.NextDouble();
                double b = a;
                Assert.AreEqual(a, maths.Maxer(a, b));
            }
        }

        [TestMethod]
        public void TestMinnerEqual()
        {
            WendysMath maths = new();
            Random rand = new();
            for (int j=0; j<10; j++)
            {
                double a = rand.NextInt64() + rand.NextDouble();
                double b = a;
                Assert.AreEqual(a, maths.Minner(a, b));
            }
        }

        [TestMethod]
        public void TestPowerNegative()
        {
            WendysMath maths = new();
            Random rand = new();
            for (int j=1; j<10; j++)
            {
                var baseNum = rand.Next(100);
                int exp = -j;
                double expectedResult = Math.Pow(baseNum, exp);
                Console.WriteLine("Input value is " + baseNum + " and " + exp);
                Assert.AreEqual(expectedResult, maths.Power(baseNum, exp));

            }
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
            WendysMath maths = new();
            Random rand = new();
            for (int j = 0; j < 10; j++)
            {
                double a = rand.NextInt64();
                int b = 0;
                Console.WriteLine("Input value is " + a + " and " + b);
                Assert.AreEqual(1, maths.Power(a, b));

            }
            
        }

        [TestMethod]
        public void TestFloorer()
        {
            WendysMath maths = new();
            Random rand = new();
            for (int j = 0; j < 10; j++)
            {
                double a = rand.NextInt64();
                int expectedResult = (int)Math.Floor(a);
                Console.WriteLine("Input value is " + a);
                Assert.AreEqual(expectedResult, maths.Floorer(a));
            }
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
            WendysMath maths = new();
            Random rand = new();
            for (int j=0; j<10; j++)
            {
                double a = rand.Next() + rand.NextDouble();
                int expectedResult = (int)Math.Ceiling(a);
                Console.WriteLine("Input value is " + a + " and the Ceiling is " + expectedResult);
                Assert.AreEqual(expectedResult, maths.Ceilinger(a));
            }
        }
    }
}

