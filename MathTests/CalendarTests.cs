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
            DateTime date = new();

            for (int i = 0; i < 7; i++)
            {
                //Assert.AreEqual(DayOfWeek(i), calendars.GetDay(i));
            }
        }   
    }
}
