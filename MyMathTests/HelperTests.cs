using Microsoft.VisualStudio.TestTools.UnitTesting;
using myMath;

namespace MathTests;

[TestClass]
public class HelperTests
{

    [TestMethod]
    public void TestGetNumInput() {
        String msg = "10";
        using StringReader reader = new(msg);
        Console.SetIn(reader);
        int result = Helpers.GetNumberInput();
        Assert.AreEqual(int.Parse(msg), result);
    }   


    [TestMethod]
    public void TestWriteMessage() {
        String msg = "This is a test!";
        using StringWriter writer = new();
        using StringReader reader = new(msg);
        Console.SetOut(writer);
        Console.SetIn(reader);
        Helpers.WriteMessage(msg);
        string consoleOutput = writer.ToString();
        Assert.AreEqual(msg, consoleOutput.TrimEnd());
    }

    [TestMethod]
    public void TestGetOptionInput() {
        String msg = "4";
        using StringReader reader = new(msg);
        Console.SetIn(reader);
        int result = Helpers.GetOption("Select the operation to perform: ");
        Assert.AreEqual(int.Parse(msg), result);

    }

    [TestMethod]
    public void TestGetOptionInputInvalid()
    {
       	using StringReader reader = new("invalid");
    	Console.SetIn(reader);
    	int result = Helpers.GetOption("Select the operation to perform: ");
    	Assert.AreEqual(0, result); 
    }

    [TestMethod]
    [DataTestMethod]
    [DataRow(new[] { "1", "2", "3", "4", "5" }, new[] {1, 2, 3, 4, 5})]
    public void TestSelectOperation(string[] input, int[] output) 
    {
        for( int cnt=0; cnt<input.Length; cnt++)
        {
            using StringReader reader = new(input[cnt]);
            Console.SetIn(reader);
            int actual = Helpers.SelectOperation();
            Assert.AreEqual(output[cnt], actual);
        }
    }

    [TestMethod]
    public void TestDoublePerformOperation()
    {
        Random rnd = new();
        int num = rnd.Next();
        int actual = Helpers.PerformAnOperation(1, num);
        Assert.AreEqual(num*2, actual);
    }

    [TestMethod]
    public void TestSquarePerformOperation()
    {
        Random rnd = new();
        int num = rnd.Next() / 100000;
        int actual = Helpers.PerformAnOperation(2, num);
        Assert.AreEqual(num*num, actual);
    }

    [TestMethod]
    public void TestAddPerformOperation()
    {
        Random rnd = new();
        int num = rnd.Next()/10000;
        int actual = Helpers.PerformAnOperation(3, num);
        Assert.AreEqual(num+num, actual);
    }

       [TestMethod]
        public void NewMethodTest() 
        {
            Assert.AreEqual("Hello World", myMath.Helpers.NewMethod());
        }

        [TestMethod]
        public void AnotherMethodTest()
        {
            Assert.AreEqual(true, myMath.Helpers.DoSomething2(1,1));
        }

        [TestMethod]
        public void DoSomethingNotEqualTest()
        {
            Assert.IsFalse(myMath.Helpers.DoSomething2(1, 0));
        }

        [TestMethod]
        public void ParseDateString_ValidDateString_ReturnsDateTime()
        {
            // Arrange
            string dateString = "20220101";
            DateTime expectedDate = new(2022, 1, 1);

            // Act
            DateTime actualDate = myMath.Helpers.ParseDateString(dateString);

            // Assert
            Assert.AreEqual(expectedDate, actualDate);
        }

        [TestMethod]
        public void ParseDateString_InValidDateString_ReturnsDateTime()
        {
            // Arrange
            string dateString = "ABCDEFG";
            Assert.ThrowsException<ArgumentException>(() => myMath.Helpers.ParseDateString(dateString));
        }

        [TestMethod]
        public void ParseDateString_InvalidDateString_ThrowsArgumentException()
        {
            // Arrange
            string dateString = "2022-01-01";

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => myMath.Helpers.ParseDateString(dateString));
        }

        [TestMethod]
        public void ParseTimeString_ReturnsTime() {
            string timeString = "115216";
            String todayString = DateTime.Now.ToString("yyyyMMdd") + timeString;
            DateTime expectedDate = DateTime.ParseExact(todayString, "yyyyMMddHHmmss", null);
            DateTime actualDate = myMath.Helpers.ParseTimeString(timeString);
            Assert.AreEqual(expectedDate, actualDate);
        }

}
