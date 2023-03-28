using System;

namespace myMath
{
    public class Program
    {
        private const string myMessage = "Hello World! Your original number is ";

        public static void Main()
        {
            int myNum;
            string? fullMessage;
            int num;
            num = Helpers.GetNumberInput();
            int operation = Helpers.SelectOperation();
            myNum = Helpers.PerformOperation(operation, num);
            fullMessage = myMessage + num + " and after the operation it is " + myNum;
            Helpers.WriteMessage(fullMessage);
        }




     }


}