using Microsoft.VisualStudio.TestTools.UnitTesting;
using myMath;

namespace MathTests;

[TestClass]
public class HelperTests
{

    [TestMethod]
    public void testGetNumInput() {
        String msg = "10";
        using (StringReader reader = new(msg))
        {
            Console.SetIn(reader);
            int result = Helpers.GetNumberInput();
            Assert.AreEqual(int.Parse(msg), result);
        }
    }       


    [TestMethod]
    public void testWriteMessage() {
        String msg = "This is a test!";
        using (StringWriter writer = new())
        using (StringReader reader = new(msg))
        {
            Console.SetOut(writer);
            Console.SetIn(reader);
            Helpers.WriteMessage(msg);
            string consoleOutput = writer.ToString();
            Assert.AreEqual(msg, consoleOutput.TrimEnd());
        }
    }

    [TestMethod]
    public void testGetOptionInput() {
        String msg = "4";
        using (StringReader reader = new(msg))
        {
            Console.SetIn(reader);
            int result = Helpers.GetOption("Select the operation to perform: ");
            Assert.AreEqual(int.Parse(msg), result);
        }

    }

    [TestMethod]
    [DataTestMethod]
    [DataRow(new[] { "1", "2", "3", "4", "5" }, new[] {1, 2, 3, 4, 5})]
    public void testSelectOperation(string[] input, int[] output) 
    {
        for( int cnt=0; cnt<input.Length; cnt++)
        {
            using (StringReader reader = new(input[cnt]))
            {
                Console.SetIn(reader);
                int actual = Helpers.SelectOperation();
                Assert.AreEqual(output[cnt], actual);
            }
        }
    }

    [TestMethod]
    public void testDoublePerformOperation()
    {
        Random rnd = new();
        int num = rnd.Next();
        int actual = Helpers.PerformOperation(1, num);
        Assert.AreEqual(num*2, actual);
    }

    [TestMethod]
    public void testSquarePerformOperation()
    {
        Random rnd = new();
        int num = rnd.Next() / 100000;
        int actual = Helpers.PerformOperation(2, num);
        Assert.AreEqual(num*num, actual);
    }

    [TestMethod]
    public void testAddPerformOperation()
    {
        Random rnd = new();
        int num = rnd.Next();
        int actual = Helpers.PerformOperation(3, num);
        Assert.AreEqual(num+num, actual);
    }


}
