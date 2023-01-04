using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace myMath
{
    public class Calendars
    {
        public string GetDay(int day)
        {
            try
            {
                switch (day)
                {
                    case 0:
                        return "Monday";
                    case 1:
                        return "Tuesday";
                    case 2:
                        return "Wednesday";
                    case 3:
                        return "Thursday";
                    case 4:
                        return "Friday";
                    case 5:
                        return "Saturday";
                    case 6:
                        return "Sunday";
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

    }
}
