namespace myMath
{
    public class Calendars
    {
        public string GetDay(int day)
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
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public string GetMonth(int month)
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
                    _ => throw new ArgumentOutOfRangeException(),
                };
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public string GetTomorrow() {
            DateTime today = DateTime.Now;
            TimeSpan duration = new(1, 0, 0, 0);
            DateTime tomorrow = today.Add(duration);
            return tomorrow.ToString("dd/MM/yyy");

        }
        
        public static class Y2KChecker
        {
            public static void Check(DateTime whatTime)
            {
                if (whatTime == new DateTime(2000, 1, 1))
                    throw new ApplicationException("y2kbug!");
                Helpers.WriteMessage("It is not January 1, 2000!");
            }
        }

    }
}
