using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMath
{
    internal class Helpers
    {
        public static void WriteMessage(String message)
        {
            Console.Write(message);
        }

        public static int GetInput(string input = "")
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


    }
}
