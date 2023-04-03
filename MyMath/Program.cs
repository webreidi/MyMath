using System;
using System.Text.RegularExpressions;


namespace myMath
{
    public class Program
    {
        private const string myMessage = "Hello World! Your original number is ";

        public static void Main()
        {
            if (AnotherMethod(9, 3))
            {
                Console.WriteLine("Through Another Method");
            }
            int num = Helpers.GetNumberInput();
            int operation = Helpers.SelectOperation();
            int myNum = Helpers.PerformAnOperation(operation, num);
            String? fullMessage = myMessage + num + " and after the operation it is " + myNum;
            Helpers.WriteMessage(fullMessage);
        }

        public static string NewMethod() => "Hello World";

        public static bool AnotherMethod(int a, int b)
        {
            SimpleMath simpleMath = new();
            string[] formats = { "yyyyMMdd", "HHmmss" };
            string[] dateStrings = { "20130816", "20131608", "  20130816   ", "115216", "521116", "  115216  " };
            DateTime parsedDate;
            string formatChange = "";


            foreach (var dateString in dateStrings)
            {
                if (DateTime.TryParseExact(dateString, formats, null,
                               System.Globalization.DateTimeStyles.AllowWhiteSpaces |
                               System.Globalization.DateTimeStyles.AdjustToUniversal,
                               out parsedDate))
                    formatChange += dateString + " --> " + parsedDate + "\n";
                else
                    formatChange += "Cannot convert " + dateString + "\n";
            }

            try
            {
                if (simpleMath.Divider(a, b) == a / b)
                {
                    string message = "They are equal.";
                    Match m = Regex.Match(message, @"\ba\w*\b", RegexOptions.IgnoreCase);
                    return m.Success;

                }
                else
                {
                    return false;
                }
            }
            catch (ArgumentOutOfRangeException)
            {

                return false;
            }
        }
    }


}


