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
    }
}
