using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myMath;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace MathTests
{
    [TestClass()]
    public class ProgramTests
    {

        readonly string expectedOutput0 = "Through Another Method";
        readonly string expectedOutput1 = "It is not January 1, 2000!"; 
        readonly string expectedOutput4 = "Please enter a number:";
        readonly string expectedOutput5 = "Select which operation to perform: [1] Double, [2] Square, [3] Add to Self, [4] Multiply to Self";
        readonly string expectedOutput2 = "Today is " + DateTime.Today;
        readonly string expectedOutput3 = "It is a leap year";

        [TestMethod()]
        [DataTestMethod]
        [DataRow(new[] { "5\n1", "1\n1", "2\n1", "3\n1", "4\n1", "6\n1", "7\n1", "8\n1", "9\n1", "10\n1" }, new[] {10, 2, 4, 6, 8, 12, 14, 16, 18, 20})]
        [Timeout(2000)]
        public void MainTestDoubled(string[] nums, int[] doubled)
        {
            for (int j = 0; j < 10; j++)
            {
                using StringWriter writer = new();
                using StringReader reader = new(nums[j]);
                Console.SetOut(writer);
                Console.SetIn(reader);
                // myMath.Program.Main();
                string consoleOutput = writer.ToString();
                int originalNum = int.Parse(nums[j].Split(new char[] { '\n' })[0]);
                string expectedOutput6 = "Hello World! Your original number is " + originalNum  + " and after the operation it is " + doubled[j];
                
                string[] actualArray = consoleOutput.Split(new char[] { '\n' });
                
                Assert.AreEqual(expectedOutput0, actualArray[0].TrimEnd());
                Assert.AreEqual(expectedOutput1, actualArray[1].TrimEnd());
                Assert.AreEqual(expectedOutput2, actualArray[2].TrimEnd());
                Assert.AreEqual(expectedOutput3, actualArray[3].TrimEnd());
                Assert.AreEqual(expectedOutput4, actualArray[4].TrimEnd());
                Assert.AreEqual(expectedOutput5, actualArray[5].TrimEnd());
                Assert.AreEqual(expectedOutput6, actualArray[7].TrimEnd());
            }
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(new[] {"5\n2", "1\n2", "2\n2", "3\n2", "4\n2", "6\n2", "7\n2", "8\n2", "9\n2", "10\n2"}, new[] {25, 1, 4, 9, 16, 36, 49, 64, 81, 100})]
        public void MainTestSquared(string[] nums, int[] squared)
        {
            for (int j= 0; j<10; j++)
            {
                using StringWriter writer = new();
                using StringReader reader = new(nums[j]);
                Console.SetOut(writer);
                Console.SetIn(reader);
                // myMath.Program.Main();

                string consoleOutput = writer.ToString();

                int originalNum = int.Parse(nums[j].Split(new char[] { '\n' })[0]);

                string expectedOutput6 = "Hello World! Your original number is " + originalNum  + " and after the operation it is " + squared[j];

                string[] actualArray = consoleOutput.Split(new char[] { '\n' });

                Assert.AreEqual(expectedOutput0, actualArray[0].TrimEnd());
                Assert.AreEqual(expectedOutput1, actualArray[1].TrimEnd());
                Assert.AreEqual(expectedOutput2, actualArray[2].TrimEnd());
                Assert.AreEqual(expectedOutput3, actualArray[3].TrimEnd());
                Assert.AreEqual(expectedOutput4, actualArray[4].TrimEnd());
                Assert.AreEqual(expectedOutput5, actualArray[5].TrimEnd());
                Assert.AreEqual(expectedOutput6, actualArray[7].TrimEnd());

            }
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(new[] {"5\n3", "1\n3", "2\n3", "3\n3", "4\n3", "6\n3", "7\n3", "8\n3", "9\n3", "10\n3"}, new[] {10, 2, 4, 6, 8, 12, 14, 16, 18, 20})]
        public void MainTestAdded(string[] nums, int[] added)
        {
            for (int j= 0; j<10; j++)
            {
                using StringWriter writer = new();
                using StringReader reader = new(nums[j]);
                Console.SetOut(writer);
                Console.SetIn(reader);
                // myMath.Program.Main();

                string consoleOutput = writer.ToString();

                int originalNum = int.Parse(nums[j].Split(new char[] { '\n' })[0]);

                string expectedOutput6 = "Hello World! Your original number is " + originalNum  + " and after the operation it is " + added[j];

                string[] actualArray = consoleOutput.Split(new char[] { '\n' });

                Assert.AreEqual(expectedOutput0, actualArray[0].TrimEnd());
                Assert.AreEqual(expectedOutput1, actualArray[1].TrimEnd());
                Assert.AreEqual(expectedOutput2, actualArray[2].TrimEnd());
                Assert.AreEqual(expectedOutput3, actualArray[3].TrimEnd());
                Assert.AreEqual(expectedOutput4, actualArray[4].TrimEnd());
                Assert.AreEqual(expectedOutput5, actualArray[5].TrimEnd());
                Assert.AreEqual(expectedOutput6, actualArray[7].TrimEnd());

            }
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(new[] {"5\n4", "1\n4", "2\n4", "3\n4", "4\n4", "6\n4", "7\n4", "8\n4", "9\n4", "10\n4"}, new[] {25, 1, 4, 9, 16, 36, 49, 64, 81, 100})]
        public void MainTestMultiplied(string[] nums, int[] multiplied)
        {
            for (int j= 0; j<10; j++)
            {
                using StringWriter writer = new();
                using StringReader reader = new(nums[j]);
                Console.SetOut(writer);
                Console.SetIn(reader);
                // myMath.Program.Main();

                string consoleOutput = writer.ToString();

                int originalNum = int.Parse(nums[j].Split(new char[] { '\n' })[0]);

                string expectedOutput6 = "Hello World! Your original number is " + originalNum  + " and after the operation it is " + multiplied[j];

                string[] actualArray = consoleOutput.Split(new char[] { '\n' });

                Assert.AreEqual(expectedOutput0, actualArray[0].TrimEnd());
                Assert.AreEqual(expectedOutput1, actualArray[1].TrimEnd());
                Assert.AreEqual(expectedOutput2, actualArray[2].TrimEnd());
                Assert.AreEqual(expectedOutput3, actualArray[3].TrimEnd());
                Assert.AreEqual(expectedOutput4, actualArray[4].TrimEnd());
                Assert.AreEqual(expectedOutput5, actualArray[5].TrimEnd());
                Assert.AreEqual(expectedOutput6, actualArray[7].TrimEnd());

            }
        }

        [TestMethod]
        public void MainTestInvalidNumber() {
            using StringWriter writer = new();
            using StringReader reader = new("a\n1");
            Console.SetOut(writer);
            Console.SetIn(reader);
            // myMath.Program.Main();

            string consoleOutput = writer.ToString();
            string[] actualArray = consoleOutput.Split(new char[] { '\n' });

            string expectedOutput6 = "Hello World! Your original number is " + 0  + " and after the operation it is " + 0;

            Assert.AreEqual(expectedOutput6, actualArray[7].TrimEnd());

        }

        [TestMethod]
        public void MainTestInvalidOption()
        {
            using StringWriter writer = new();
            using StringReader reader = new("8\na");

                        Console.SetOut(writer);
            Console.SetIn(reader);
            // myMath.Program.Main();

            string consoleOutput = writer.ToString();
            string[] actualArray = consoleOutput.Split(new char[] { '\n' });

            string expectedOutput6 = "Hello World! Your original number is " + 8  + " and after the operation it is " + 0;

            Assert.AreEqual(expectedOutput6, actualArray[7].TrimEnd());

        }

        [TestMethod()]
        public void WhatsDifferent() {
            Assert.AreEqual("Through Another Method\nPlease enter a number: Select which operation to perform: [1] Double, [2] Square, [3] Add to Self, [4] Multiply to Self\nHello World! Your original number is 5 and after the operation it is 10", "Through Another Method\nPlease enter a number: Select which operation to perform: [1] Double, [2] Square, [3] Add to Self, [4] Multiply to Self\nHello World! Your original number is 5 and after the operation it is 10");
        }

     
    }
}