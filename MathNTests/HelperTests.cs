namespace MathNTests;

public class HelperTests
{
	[SetUp]
	public void Setup()
	{
	}

	[Test]
	public void Test1()
	{
		string msg = "This is a test!";
		Assert.That(msg, Is.EqualTo(msg.Trim()));
	}

	[Test]
	public void TestGetNumInput()
	{
		String msg = "10";
		using StringReader reader = new(msg);
		Console.SetIn(reader);
		int result = Helpers.GetNumberInput();
		Assert.That(result, Is.EqualTo(int.Parse(msg)));
	}

	[Test]
	public void TestWriteMessage()
	{
		String msg = "This is a test!";
		using StringWriter writer = new();
		using StringReader reader = new(msg);
		Console.SetOut(writer);
		Console.SetIn(reader);
		Helpers.WriteMessage(msg);
		string consoleOutput = writer.ToString();
		Assert.That(consoleOutput.TrimEnd(), Is.EqualTo(msg));
	}

	[Test]
	public void TestGetOptionInput()
	{

		String msg = "4";
		using StringReader reader = new(msg);
		Console.SetIn(reader);
		int result = Helpers.GetOption("Select the operation to perform: ");
		Assert.That(result, Is.EqualTo(int.Parse(msg)));
	}

	[Test]
	public void TestGetOptionInputInvalid()
	{

		using StringReader reader = new("invalid");
		Console.SetIn(reader);
		int result = Helpers.GetOption("Select the operation to perform: ");
		Assert.That(result, Is.EqualTo(0));
	}

	[Test]
	[TestCase(new[] { "1", "2", "3", "4", "5" }, new[] { 1, 2, 3, 4, 5 })]
	public void TestSelectOperation(string[] input, int[] output)
	{

		for (int cnt = 0; cnt < input.Length; cnt++)
		{

			using StringReader reader = new(input[cnt]);
			Console.SetIn(reader);
			int actual = Helpers.SelectOperation();
			Assert.That(actual, Is.EqualTo(output[cnt]));
		}
	}

	[Test]
	public void TestDoublePerformOperation()
	{
		Random rnd = new();
		int num = rnd.Next();
		int actual = Helpers.PerformAnOperation(1, num);
		Assert.That(actual, Is.EqualTo(num * 2));

	}

	[Test]
	public void ParseDateString_InValidDateString_ReturnsDateTime()
	{
		// Arrange
		string dateString = "ABCDEFG";
		Assert.Throws<ArgumentException>(() => { myMath.Helpers.ParseDateString(dateString); });
	}

	[Test]
	public void ParseDateString_ValidDateString_ReturnsDateTime()
	{

		string dateString = "20210101";
		DateTime expected = new(2021, 1, 1);
		DateTime actual = myMath.Helpers.ParseDateString(dateString);
		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void TestSquarePerformOperation()
	{

		Random rnd = new();
		int num = rnd.Next() / 100000;
		int actual = Helpers.PerformAnOperation(2, num);
		Assert.That(actual, Is.EqualTo(num * num));
	}

	[Test]
	public void TestAddToSelfPerformOperation()
	{

		Random rnd = new();
		int num = rnd.Next() / 100000;
		int actual = Helpers.PerformAnOperation(3, num);
		Assert.That(actual, Is.EqualTo(num + num));
	}

	[Test]
	public void TestMultiplyToSelfPerformOperation()
	{

		Random rnd = new();
		int num = rnd.Next() / 100000;
		int actual = Helpers.PerformAnOperation(4, num);
		Assert.That(actual, Is.EqualTo(num * num));
	}

	[Test]
	public void TestGetDate()
	{
		DateTime date = DateTime.Now;
		string dateString = date.ToString("yyyyMMdd");
		using StringReader reader = new(dateString);
		Console.SetIn(reader);
		DateTime actual = Helpers.GetDate("Enter a date in the format YYYYMMDD: ");
		Assert.That(actual, Is.EqualTo(date));
	}



}