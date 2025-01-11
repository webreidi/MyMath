using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myMath;

namespace myMath.Tests
{
    /// <summary>This class contains parameterized unit tests for Helpers</summary>
    [PexClass(typeof(Helpers))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class HelpersTest
    {
        /// <summary>Test stub for WriteMessage(String)</summary>
        [PexMethod]
        internal void WriteMessageTest(string message)
        {
            Helpers.WriteMessage(message);
            // TODO: add assertions to method HelpersTest.WriteMessageTest(String)
        }

        [PexMethod]
        internal int GetNumberInput(string input)
        {
            int result = Helpers.GetNumberInput(input);
            return result;
            // TODO: add assertions to method HelpersTest.GetNumberInput(String)
        }

        [PexMethod]
        internal int PerformAnOperation(int operation, int num)
        {
            int result = Helpers.PerformAnOperation(operation, num);
            return result;
            // TODO: add assertions to method HelpersTest.PerformAnOperation(Int32, Int32)
        }

        [PexMethod]
        internal bool DoSomething2(int a, int b)
        {
            bool result = Helpers.ValidateAndCompareNumbers(a, b);
            return result;
            // TODO: add assertions to method HelpersTest.DoSomething2(Int32, Int32)
        }

        [PexMethod]
        internal DateTime ParseTimeString(string timeString)
        {
            DateTime result = Helpers.ParseTimeString(timeString);
            return result;
            // TODO: add assertions to method HelpersTest.ParseTimeString(String)
        }

        [PexMethod]
        internal DateTime ParseDateString(string dateString)
        {
            DateTime result = Helpers.ParseDateString(dateString);
            return result;
            // TODO: add assertions to method HelpersTest.ParseDateString(String)
        }

        [PexMethod]
        internal double Divide(
            [PexAssumeUnderTest] Helpers target,
            double dividend,
            double divisor
        )
        {
            double result = target.Divide(dividend, divisor);
            return result;
            // TODO: add assertions to method HelpersTest.Divide(Helpers, Double, Double)
        }

        [PexMethod]
        internal int GetOption(string msg)
        {
            int result = Helpers.GetOption(msg);
            return result;
            // TODO: add assertions to method HelpersTest.GetOption(String)
        }

        [PexMethod]
        internal int SelectOperation()
        {
            int result = Helpers.SelectOperation();
            return result;
            // TODO: add assertions to method HelpersTest.SelectOperation()
        }

        [PexMethod]
        internal string NewMethod()
        {
            string result = Helpers.NewMethod();
            return result;
            // TODO: add assertions to method HelpersTest.NewMethod()
        }
    }

    [TestMethod]
        public void GetInput_ReturnsInput_WhenInputIsNotNull()
        {
            // Arrange
            string expected = "test input";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                using (var sr = new StringReader(expected))
                {
                    Console.SetIn(sr);

                    // Act
                    string result = Helpers.GetInput("Enter something:");

                    // Assert
                    Assert.AreEqual(expected, result);
                }
            }
        }

        [TestMethod]
        public void GetInput_ReturnsEmptyString_WhenInputIsNull()
        {
            // Arrange
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                using (var sr = new StringReader(string.Empty))
                {
                    Console.SetIn(sr);

                    // Act
                    string result = Helpers.GetInput("Enter something:");

                    // Assert
                    Assert.AreEqual(string.Empty, result);
                }
            }
        }

        [TestMethod]
        public void GetInput_WritesMessageToConsole()
        {
            // Arrange
            string message = "Enter something:";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                using (var sr = new StringReader("test input"))
                {
                    Console.SetIn(sr);

                    // Act
                    Helpers.GetInput(message);

                    // Assert
                    string consoleOutput = sw.ToString().Trim();
                    Assert.IsTrue(consoleOutput.Contains(message));
                }
            }
        }
    }
}