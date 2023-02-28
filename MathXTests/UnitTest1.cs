namespace MathXTests;

using myMath;
using static myMath.Calendars;

public class UnitTest1
{
    [Fact]
    public void PrintMonthTest()
    {
        //Console.WriteLine("This is the PrintDay Test Running.");
        Calendars calendars = new();
        Assert.Equal("January", calendars.GetMonth(0));
        Assert.Equal("February", calendars.GetMonth(1));
        Assert.Equal("March", calendars.GetMonth(2));
        Assert.Equal("April", calendars.GetMonth(3));
        Assert.Equal("May", calendars.GetMonth(4));
        Assert.Equal("June", calendars.GetMonth(5));
        Assert.Equal("July", calendars.GetMonth(6));
        Assert.Equal("August", calendars.GetMonth(7));
        Assert.Equal("September", calendars.GetMonth(8));
        Assert.Equal("October", calendars.GetMonth(9));
        Assert.Equal("November", calendars.GetMonth(10));
        Assert.Equal("December", calendars.GetMonth(11));
        
    }

    [Fact]
    public async void MonthThrowsAsync()
    {
        Func<Task> testCode = () => Task.Factory.StartNew(MonthThrowingMethod);

        ArgumentOutOfRangeException ex = await Assert.ThrowsAsync<ArgumentOutOfRangeException>(testCode);

        Assert.IsType<ArgumentOutOfRangeException>(ex);
    }

    [Fact]
    public async void DayThrowsAsync()
    {
        Func<Task> testCode = () => Task.Factory.StartNew(DayThrowingMethod);

        ArgumentOutOfRangeException ex = await Assert.ThrowsAsync<ArgumentOutOfRangeException>(testCode);

        Assert.IsType<ArgumentOutOfRangeException>(ex);
    }

    [Fact]
    public void TestY2KChecker() {
        string expected = "It is not January 1, 2000!";
        using (StringWriter wr = new())
        {
            Console.SetOut(wr);
            Y2KChecker.Check();
            string actual = wr.ToString();
            Assert.Equal(expected, actual);
        };
    }

    [Fact]
    public async void TestY2KCheckerThrowsAsync() {
        Func<Task> testCode = () => Task.Factory.StartNew(DayThrowingMethod);

        ApplicationException ex = await Assert.ThrowsAsync<ApplicationException>(testCode);

        Assert.IsType<ApplicationException>(ex);
    }
    
    private void MonthThrowingMethod()
    {
        Calendars calendars = new();
        calendars.GetMonth(12);
    }

    private void DayThrowingMethod()
    {
        Calendars calendars = new();
        calendars.GetDay(7);
    }

    private void Y2KCheckerThrowingMethod()
    {
        //unit test code
        // create a ShimsContext cleans up shims
//        using (ShimsContext.Create()) {
//            // hook delegate to the shim method to redirect DateTime.Now
//            // to return January 1st of 2000
//            ShimDateTime.NowGet = () => new DateTime(2000, 1, 1);
//            Y2KChecker.Check();
 //       }
    }
}