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
            else
            {
            
            	Console.WriteLine("DoSomething Failed.");
            }


            //Check if the year is Y2K
            DateTime today = DateTime.Today;
            Calendars.Y2KChecker.Check(today);
            Helpers.WriteMessage("Today is " + today);

            //Check if the year is a leap year
            if (Calendars.IsLeapYear(today)) Helpers.WriteMessage("It is a leap year");
			else Helpers.WriteMessage("It is not a leap year");

            //Get a number from the user
            //Find out what operation they want to perform
            //Perform the operation
            //Write the result to the console
            int num = Helpers.GetNumberInput();
            int operation = Helpers.SelectOperation();
            int myNum = Helpers.PerformAnOperation(operation, num);
            string? fullMessage = myMessage + num + " and after the operation it is " + myNum;
            Helpers.WriteMessage(fullMessage);
            Helpers.WriteMessage("\n");

            //exit the program
            Helpers.WriteMessage("Press any key to exit...");
            Console.ReadLine();
        }
    }


}


