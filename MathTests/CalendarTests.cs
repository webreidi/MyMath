using myMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MathTests
{
    [TestClass]
    public class CalendarTests
    {
        [TestMethod]
        public void PrintDayTest()
        {
            Console.WriteLine("This is the PrintDay Test Running.");
            Calendars calendars = new();
            Assert.AreEqual("Monday", calendars.GetDay(0));
            Assert.AreEqual("Tuesday", calendars.GetDay(1));
            Assert.AreEqual("Wednesday", calendars.GetDay(2));
            Assert.AreEqual("Thursday", calendars.GetDay(3));
            Assert.AreEqual("Friday", calendars.GetDay(4));
            Assert.AreEqual("Saturday", calendars.GetDay(5));
            Assert.AreEqual("Sunday", calendars.GetDay(6));
        }   

        [TestMethod]
        public void PrintMonthTest()
        {
            Calendars calendars = new();
            Assert.AreEqual("January", calendars.GetMonth(0));
        }

        [TestMethod]
        public void PrintDayThrowsTest()
        {
            //ArgumentOutOfRangeException ex = PrintDayThrow();
            //Assert.AreEqual(new ArgumentOutOfRangeException(), ex);
        }

        [TestMethod]
        public async Task PrintDayThrow()
        {
            static Task testCode() => Task.Factory.StartNew(DayThrowingMethod);

            ArgumentOutOfRangeException ex = await Assert.ThrowsExceptionAsync<ArgumentOutOfRangeException>(testCode);

        }

        public static void DayThrowingMethod() {
            Calendars calendars = new();
            calendars.GetDay(7);
        }
    }
}
