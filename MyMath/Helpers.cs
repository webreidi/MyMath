using System.Text.RegularExpressions;

namespace myMath
{
    internal partial class Helpers
    {
        private const int V = 0;

        public virtual double Divide(double dividend, double divisor)
        {
            SimpleMath simpleMath = new();
            return simpleMath.Divider(dividend, divisor);
        }
        
        public static void WriteMessage(String message)
        {
            Console.WriteLine(message);
        }

        public static int GetNumberInput(string? input = "")
        {
            WriteMessage("Please enter a number: ");
            if (input == "")
                input = Console.ReadLine();
            bool success = int.TryParse(input, out int num);
            if (success)
            {
                return num;
            }
            else
            {
                return 0;
            }
        }

        public static int GetOption(string msg)
        {
            WriteMessage(msg);
            String? input = Console.ReadLine();
            bool success = int.TryParse(input, out int num);
            if (success)
            {
                return num;
            }
            else
            {
                return 0;
            }
        }

        public static int SelectOperation()
        {
            string msg = "Select which operation to perform: [1] Double, [2] Square, [3] Add to Self, [4] Multiply to Self\n";
            return Helpers.GetOption(msg);

        }

        public static int PerformAnOperation(int operation, int num)
        {
            SimpleMath myMath = new();
            Squarer mySquarer = new();
            _ = new WendysMath();

            int v = operation switch
            {
                1 => myMath.DoubleNum(num),
                2 => (int)mySquarer.Square(Convert.ToDouble(num)),
                3 => (int)myMath.Adder(Convert.ToDouble(num), Convert.ToDouble(num)),
                4 => (int)myMath.Multiplier(Convert.ToDouble(num), Convert.ToDouble(num)),
                _ => V,
            };
            return v;
        }

        public static string NewMethod() => "Hello World";

        public static bool DoSomething2(int a, int b)
        {
            SimpleMath simpleMath = new();
            string[] formats = { "yyyyMMdd", "HHmmss" };
            string[] dateStrings = { "20130816", "20131608", "  20130816   ", "115216", "521116", "  115216  " };
            string formatChange = "";


            foreach (var dateString in dateStrings)
            {
                if (DateTime.TryParseExact(dateString, formats, null,
                               System.Globalization.DateTimeStyles.AllowWhiteSpaces |
                               System.Globalization.DateTimeStyles.AdjustToUniversal,
                               out DateTime parsedDate))
                    formatChange += dateString + " --> " + parsedDate + "\n";
                else
                    formatChange += "Cannot convert " + dateString + "\n";
            }

            try
            {
                if (simpleMath.Divider(a, b) == a / b)
                {
                    string message = "They are equal.";
                    Match m = LangRegex().Match(message);
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
        
        public static DateTime ParseTimeString(string timeString)
        {
            string[] formats = { "yyyyMMdd", "HHmmss" };

            if (DateTime.TryParseExact(timeString, formats, null, System.Globalization.DateTimeStyles.AllowWhiteSpaces | 
                System.Globalization.DateTimeStyles.AdjustToUniversal, out DateTime parsedDate))
            {
                return parsedDate;
            }
            else
            {
                throw new ArgumentException("Invalid date string format.");
            }
        }
        public static DateTime ParseDateString(string dateString)
        {
            string[] formats = { "yyyyMMdd", "HHmmss" };

            if (DateTime.TryParseExact(dateString, formats, null,
                System.Globalization.DateTimeStyles.AllowWhiteSpaces |
                System.Globalization.DateTimeStyles.AdjustToUniversal,
                out DateTime parsedDate))
            {
                return parsedDate;
            }
            else
            {
                throw new ArgumentException("Invalid date string format.");
            }
        }
        
        [GeneratedRegex("\\ba\\w*\\b", RegexOptions.IgnoreCase, "en-US")]
        private static partial Regex LangRegex();


    }    

}
