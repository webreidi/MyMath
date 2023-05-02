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
                Program.Main();
                string consoleOutput = writer.ToString();
                int originalNum = int.Parse(nums[j].Split(new char[] { '\n' })[0]);
                string expectedOutput0 = "Through Another Method";
                string expectedOutput1 = "Please enter a number: Select which operation to perform: [1] Double, [2] Square, [3] Add to Self, [4] Multiply to Self";
                string expectedOutput2 = "Hello World! Your original number is " + originalNum  + " and after the operation it is " + doubled[j];
                
                string[] actualArray = consoleOutput.Split(new char[] { '\n' });
                
                Assert.AreEqual(expectedOutput0, actualArray[0].TrimEnd());
                Assert.AreEqual(expectedOutput1, actualArray[1].TrimEnd());
                Assert.AreEqual(expectedOutput2, actualArray[2].TrimEnd());
            }
        }

        [TestMethod()]
        public void WhatsDifferent() {
            Assert.AreEqual("Through Another Method\nPlease enter a number: Select which operation to perform: [1] Double, [2] Square, [3] Add to Self, [4] Multiply to Self\nHello World! Your original number is 5 and after the operation it is 10", "Through Another Method\nPlease enter a number: Select which operation to perform: [1] Double, [2] Square, [3] Add to Self, [4] Multiply to Self\nHello World! Your original number is 5 and after the operation it is 10");}

        [TestMethod]
        public void NewMethodTest() 
        {
            Assert.AreEqual("Hello World", Program.NewMethod());
        }

        [TestMethod]
        public void AnotherMethodTest()
        {
            Assert.AreEqual(true, Program.AnotherMethod(1,1));
        }
    }
}