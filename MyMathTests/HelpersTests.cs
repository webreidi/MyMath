using Microsoft.VisualStudio.TestTools.UnitTesting;
using myMath;

namespace MathTests
{
    [TestClass]
    public class HelpersTests
    {
        [TestMethod]
        public void TestDivide()
        {
            // Arrange
            var helpers = new Helpers();
            double dividend = 10;
            double divisor = 2;
            double expected = 5;

            // Act
            double actual = helpers.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestWriteMessage()
        {
            // Arrange
            string expectedMessage = "Test message";

            // Act
            using var sw = new StringWriter();
            Console.SetOut(sw);
            Helpers.WriteMessage(expectedMessage); // Call the static method on the type, not the instance
            // Assert
            var result = sw.ToString().Trim();
            Assert.AreEqual(expectedMessage, result);
        }
    }
}