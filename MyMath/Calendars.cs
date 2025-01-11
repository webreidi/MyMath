namespace myMath
{
    public class Calendars
    {
		/// <summary>
		/// Returns the name of the day based on the provided integer.
		/// </summary>
		/// <param name="day">The integer representation of the day, where 0 is Monday and 6 is Sunday.</param>
		/// <returns>The name of the day as a string.</returns>
		/// <exception cref="ArgumentOutOfRangeException">Thrown when the provided integer is not between 0 and 6.</exception>
		public static string GetDay(int day)
        {
            try
            {
                return day switch
                {
                    0 => "Monday",
                    1 => "Tuesday",
                    2 => "Wednesday",
                    3 => "Thursday",
                    4 => "Friday",
                    5 => "Saturday",
                    6 => "Sunday",
                    _ => throw new ArgumentOutOfRangeException(paramName: nameof(day), message: "Not a valid day")
                };
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(day), message: "Not a valid day");
            }
        }

		/// <summary>
		/// Returns the name of the month based on the provided integer.
		/// </summary>
		/// <param name="month">The integer representation of the month, where 0 is January and 11 is December.</param>
		/// <returns>The name of the month as a string.</returns>
		/// <exception cref="ArgumentOutOfRangeException">Thrown when the provided integer is not between 0 and 11.</exception>
		public static string GetMonth(int month)
        {
            try
            {
                return month switch
                {
                    0 => "January",
                    1 => "February",
                    2 => "March",
                    3 => "April",
                    4 => "May",
                    5 => "June",
                    6 => "July",
                    7 => "August",
                    8 => "September",
                    9 => "October",
                    10 => "November",
                    11 => "December",
                    _ => throw new ArgumentOutOfRangeException(paramName: nameof(month), message: "Not a valid month"),
                };
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(month), message: "Not a valid month");
            }
        }

        /// <summary>
        /// Returns the current date in the format dd/MM/yyyy.
        /// </summary>
        /// <returns>The current date in the format dd/MM/yyyy as a string.</returns>
        public static string GetTomorrow() {
            DateTime today = DateTime.Now;
            TimeSpan duration = new(1, 0, 0, 0);
            DateTime tomorrow = today.Add(duration);
            return tomorrow.ToString("dd/MM/yyy");

        }

		/// <summary>
        /// Returns boolean value indicating whether the provided date is a leap year.
        /// </summary>
        /// <param name="date">A DateTime object</param>
        /// <returns>boolean indicating whether the provided date is a leap year.</returns>
        public static bool IsLeapYear(DateTime date)
		{
			int year = date.Year;
			return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
		}

        public static class Y2KChecker
        {
            /// <summary>
            /// Prints a message to the console if the provided date is not January 1, 2000.
            /// </summary>
            /// <param name="whatTime">A DateTime object</param>
            /// <exception cref="ApplicationException">Thows an ApplicationException if the date is January 1, 2000.</exception>
            public static void Check(DateTime whatTime)
            {
                if (whatTime == new DateTime(2000, 1, 1))
                    throw new ApplicationException("y2kbug!");
                Helpers.WriteMessage("It is not January 1, 2000!");
            }
        }

        public static int GetYear(DateTime date)
        {

            return date.Year;
        }

        public static int GetYear()
        {
            return DateTime.Now.Year;
        }

    }
}
