using Microsoft.VisualStudio.TestTools.UnitTesting;
using myMath;

namespace MathTests
{
    [TestClass]
    public class RooterTest
    {
        [TestMethod]
        public void TestSquareRoot()
        {
            // Arrange
            Rooter rooter = new Rooter();
            double input = 16.0;
            double expectedOutput = 4.0;

            // Act
            double actualOutput = rooter.SquareRoot(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput, 0.001);
        }
    }
}