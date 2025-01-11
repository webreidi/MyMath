using myMath;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

string myMessage = "Hello World! Your original number is ";
string? readResult;
string menuSelection = "";

do
{
	// display the top-level menu options

	//Comment out Console.Clear() if you run into issues with debugging your application
	// Console.Clear();

	Console.WriteLine("Welcome to my Math application. Your main menu options are:");
	Console.WriteLine(" 1. Do some math");
	Console.WriteLine(" 2. Calendar fun");
	Console.WriteLine(" 3. Advanced math");
	Console.WriteLine(" 4. Advanced calendar");
	Console.WriteLine(" 5. I'm feeling lucky");
	Console.WriteLine();
	Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

	readResult = Console.ReadLine();
	if (readResult != null)
	{
		menuSelection = readResult.ToLower();
	}
	switch (menuSelection)
	{
		case "1":
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
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
		case "2":
			//Check if the year is Y2K
			DateTime today = DateTime.Today;
			Calendars.Y2KChecker.Check(today);
			Helpers.WriteMessage("Today is " + today.ToLongDateString());

			//Check if the year is a leap year
			if (Calendars.IsLeapYear(today))
				Helpers.WriteMessage("It is a leap year");
			else
				Helpers.WriteMessage("It is not a leap year");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
		case "3":
			//Advanced Math
			Random random = new();
			Primer primer = new();
			for (int i = 0; i < 10; i++)
			{
				int number = random.Next(0, 10000);
				if (primer.IsPrime(number))
				{
					Helpers.WriteMessage(number + " is prime");
				}
				else
				{
					Helpers.WriteMessage(number + " is not prime");
				}
			}
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
		case "4":
			//Advanced Calendar
			DateTime enteredDate = Helpers.GetDate("Enter your birthdate:");
			if (enteredDate == DateTime.Now)
			{
				Helpers.WriteMessage("Happy Birthday!!!");
			}
			else
			{
				//remove the year from enteredDate and make it this year, then calculate the time until that date
				enteredDate = enteredDate.AddYears(DateTime.Now.Year - enteredDate.Year);
				TimeSpan daysUntil;
				if (enteredDate.Month < DateTime.Now.Month)
					daysUntil = DateTime.Now - enteredDate;
				else
					daysUntil = enteredDate - DateTime.Now;
				Helpers.WriteMessage("There are " + daysUntil.Days + " days until your birthday.");
			}

			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
		case "5":
			//I'm feeling lucky
			Random rnd = new();
			if (Helpers.ValidateAndCompareNumbers(rnd.Next(0, 100), rnd.Next(0, 100)))
			{
				Helpers.WriteMessage("There were no 0 denominators.");
			}
			else
			{
				Helpers.WriteMessage("We got a 0. It Failed.");
			}
			//TODO: Add a call to the new method here
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
		default:
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;
	}
} while (menuSelection != "exit");