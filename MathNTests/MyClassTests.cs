using NUnit.Framework;
using myMath;

namespace MathNTests
{
    [TestFixture]
    public class MyClassTests
    {
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            int result = MyClass.Add(2, 3);
            Assert.That(5, Is.EqualTo(result));
        }

        [Test]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            int result = MyClass.Add(5, -3);
            Assert.That(2, Is.EqualTo(result));
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            int result = MyClass.Add(-4, -6);
            Assert.That(-10, Is.EqualTo(result));
        }

        [Test]
        public void Add_NumberAndZero_ReturnsSameNumber()
        {
            int result = MyClass.Add(7, 0);
            Assert.That(7, Is.EqualTo(result));
        }
    }
}