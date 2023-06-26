using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMath
{
    internal class Helpers
    {
        public virtual double Divide(double dividend, double divisor)
        {
            SimpleMath simpleMath = new();
            return simpleMath.Divider(dividend, divisor);
        }
        
        public static void WriteMessage(String message)
        {
            Console.Write(message);
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
            WendysMath moreMath = new();

            switch (operation)
            {
                case 1:
                    return myMath.DoubleNum(num);
                case 2:
                    return (int)mySquarer.Square(Convert.ToDouble(num));
                case 3:
                    return (int)myMath.Adder(Convert.ToDouble(num), Convert.ToDouble(num));
                case 4:
                    return (int)myMath.Multiplier(Convert.ToDouble(num), Convert.ToDouble(num));
                default:
                    return 0;
            }
        }


    }
}
