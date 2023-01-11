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
        [DataRow(new[] { "5", "1", "2", "3", "4", "6", "7", "8", "9", "10" }, new[] {10, 2, 4, 6, 8, 12, 14, 16, 18, 20})]
        [Timeout(2000)]
        public void MainTest1(string[] nums, int[] doubled)
        {
            for (int j = 0; j < 10; j++)
            {
                using (StringWriter writer = new())
                using (StringReader reader = new(nums[j]))
                {
                    Console.SetOut(writer);
                    Console.SetIn(reader);
                    Program.Main();
                    string consoleOutput = writer.ToString();
                    string expectedOutput = "Please enter a number: Hello World! " + doubled[j];
                    Console.WriteLine(expectedOutput);
                    Assert.AreEqual(expectedOutput, consoleOutput.TrimEnd());
                }
            }
        }

        [TestMethod()]
        public void WhatsDifferent() {
            Assert.AreEqual("Please enter a number: Hello World! 10", "Please enter a number: Hello World! 10");
        }

    }
}