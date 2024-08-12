using myMath;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

string myMessage = "Hello World! Your original number is ";

Random rnd = new();
if (Helpers.DoSomething2(rnd.Next(0,100), rnd.Next(0,100)))
{
	Helpers.WriteMessage("Through Another Method");
} else
{
	Helpers.WriteMessage("DoSomething Failed.");
}

//Check if the year is Y2K
DateTime today = DateTime.Today;
Calendars.Y2KChecker.Check(today);
Helpers.WriteMessage("Today is " + today.ToLongDateString());

//Check if the year is a leap year
if (Calendars.IsLeapYear(today))
	Helpers.WriteMessage("It is a leap year");
else
	Helpers.WriteMessage("It is not a leap year");

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

Helpers.WriteMessage("Here's something else:\n");
DateTime enteredDate = Helpers.GetDate("Enter your birthdate:");
if (enteredDate == DateTime.Now)
{
	Helpers.WriteMessage("Happy Birthday!!!");
} else
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

//exit the program
Helpers.GetInput("Press any key to exit...");
