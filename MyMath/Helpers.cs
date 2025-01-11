using Microsoft.VisualBasic;
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
            string msg = "Please enter a number: ";

            if (input == "")
                input = GetInput(msg);
            bool success = int.TryParse(input, out int num);
            if (success)
                return num;
            else
                return 0;
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

        public static DateTime GetDate(string msg)
        {
            WriteMessage(msg);
            String? input = Console.ReadLine();
            string[] formats = { "yyyyMMdd", "MMddyyyy" };
            bool success = DateTime.TryParseExact(input, formats, null, System.Globalization.DateTimeStyles.None, out DateTime date);
            if (success)
            {
                return date;
            }
            else
            {
                return DateTime.MinValue;
            }
        }

        public static string GetInput(string msg)
        {
            WriteMessage(msg);
            String? input = Console.ReadLine();
            if (input == null)
            {
                return "";
            }
            else
            {
                return input;
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

        public static bool ValidateAndCompareNumbers(int a, int b)
        {
            SimpleMath simpleMath = new();

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

        public static int DoSomethingFun()
        {
            return 42;
        }


        public static string DoSomethingElseFun()
        {
            SimpleMath simpleMath = new();
            int doubleNum = simpleMath.DoubleNum(21);
            double subrractNum = simpleMath.Subtractor(21, 21);
            return "Hello World";
        }



        [GeneratedRegex("\\ba\\w*\\b", RegexOptions.IgnoreCase, "en-US")]
        private static partial Regex LangRegex();

    }

}
