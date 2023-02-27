using Microsoft.VisualStudio.TestTools.UnitTesting;
using myMath;

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
            Assert.AreEqual("February", calendars.GetMonth(1));
            Assert.AreEqual("March", calendars.GetMonth(2));
            Assert.AreEqual("April", calendars.GetMonth(3));
            Assert.AreEqual("May", calendars.GetMonth(4));
            Assert.AreEqual("June", calendars.GetMonth(5));
            Assert.AreEqual("July", calendars.GetMonth(6));
            Assert.AreEqual("August", calendars.GetMonth(7));
            Assert.AreEqual("September", calendars.GetMonth(8));
            Assert.AreEqual("October", calendars.GetMonth(9));
            Assert.AreEqual("November", calendars.GetMonth(10));
            Assert.AreEqual("December", calendars.GetMonth(11));
        }
    }
}
