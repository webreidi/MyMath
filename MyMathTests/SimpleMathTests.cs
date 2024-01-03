using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myMath;

namespace MathTests
{
    [TestClass]
    public class SimpleMathTests
    {
        [TestMethod]
        public void AdderTest()
        {
            Console.WriteLine("This is the Adder Test Running.");
            SimpleMath simplemaths = new();
            Random rnd = new();
            
            for (int i=-10; i<10; i++)
            {
                double b = rnd.NextDouble();
                double expected = i + b;
                Console.WriteLine("Testing where a = " + i + " and b = " + b + " giving the result of " + expected);
                Assert.AreEqual(expected, simplemaths.Adder(i, b));
            }
        }
        
        [TestMethod]
        public void SubtractorTest()
        {
            Console.WriteLine("This is the subtraction tester running.");
            SimpleMath simplemaths = new();
            Random rnd = new();
            
            for (int i=-10; i<10; i++)
            {
                double b = rnd.NextDouble();
                double expected = i - b;
                Console.WriteLine("Testing where a = " + i + " and b = " + b + " giving the result of " + expected);
                Assert.AreEqual(expected, simplemaths.Subtractor(i, b));
            }
        }

        [TestMethod]
        public void MulitplierTest()
        {
            SimpleMath simplemaths = new();
            Random rnd = new();

            for (int i = -10; i < 10; i++)
            {
                double b = rnd.NextDouble();
                double expected = i * b;
                Console.WriteLine("Testing where a = " + i + " and b = " + b + " giving the result of " + expected);
                Assert.AreEqual(expected, simplemaths.Multiplier(i, b));
            }
        }

        [TestMethod]
        public void DividerTest()
        {
			SimpleMath simplemaths = new();
			Random rnd = new();

			for (int i = -10; i < 10; i++)
			{
				double b = rnd.NextDouble();
				double expected = i / b;
				Console.WriteLine("Testing where a = " + i + " and b = " + b + " giving the result of " + expected);
				Assert.AreEqual(expected, simplemaths.Divider(i, b));
			}
		}
	}


}
