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
            for (int j=0; j<10; j++) {
                num = Helpers.GetInput();
                myNum = myMath.DoubleNum(num);
                fullMessage = myMessage + myNum;
                Helpers.WriteMessage(fullMessage);
            }

        }

     }
}