namespace myMath
{
    public partial class Program
    {
        private const string myMessage = "Hello World! Your original number is ";

        public static void Main()
        {
            if (Helpers.DoSomething2(9, 3))
            {
                Console.WriteLine("Through Another Method");
            }
            int num = Helpers.GetNumberInput();
            int operation = Helpers.SelectOperation();
            int myNum = Helpers.PerformAnOperation(operation, num);
            string? fullMessage = myMessage + num + " and after the operation it is " + myNum;
            Helpers.WriteMessage(fullMessage);
            Helpers.WriteMessage("\n");
            Helpers.WriteMessage("Press any key to exit...");
            Console.ReadLine();
        }
    }


}


