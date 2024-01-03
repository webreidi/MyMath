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
			Assert.AreEqual("Monday", Calendars.GetDay(0));
			Assert.AreEqual("Tuesday", Calendars.GetDay(1));
			Assert.AreEqual("Wednesday", Calendars.GetDay(2));
			Assert.AreEqual("Thursday", Calendars.GetDay(3));
			Assert.AreEqual("Friday", Calendars.GetDay(4));
			Assert.AreEqual("Saturday", Calendars.GetDay(5));
			Assert.AreEqual("Sunday", Calendars.GetDay(6));
		}

		[TestMethod]
		public void PrintMonthTest()
		{
			Calendars calendars = new();
			Assert.AreEqual("January", Calendars.GetMonth(0));
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

		[TestMethod]
		public void TestIsLeapYear()
		{
			// Arrange
			DateTime leapYearDate = new DateTime(2020, 1, 1);
			DateTime nonLeapYearDate = new DateTime(2019, 1, 1);

			// Act
			bool isLeapYear = Calendars.IsLeapYear(leapYearDate);
			bool isNonLeapYear = Calendars.IsLeapYear(nonLeapYearDate);

			// Assert
			Assert.IsTrue(isLeapYear);
			Assert.IsFalse(isNonLeapYear);
		}


		public static void DayThrowingMethod()
		{
			Calendars calendars = new();
			Calendars.GetDay(7);
		}
	}
}
