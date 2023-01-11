using System;

namespace myMath
{
    public class Program
    {
        private const string myMessage = "Hello World! ";

        public static void Main()
        {
            int myNum;
            string? fullMessage;
            int num;
            SimpleMath myMath = new();
            num = Helpers.GetInput();
            myNum = myMath.DoubleNum(num);
            fullMessage = myMessage + myNum;
            Helpers.WriteMessage(fullMessage);
        }

     }
}