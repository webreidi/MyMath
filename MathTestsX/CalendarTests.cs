namespace MathXTests;

using System;
using static myMath.Calendars;



public class CalendarTests
{
    [Fact]
    public void PrintDayTest() 
    {
        Assert.Equal("Monday", GetDay(0));
        Assert.Equal("Tuesday", GetDay(1));
        Assert.Equal("Wednesday", GetDay(2));
        Assert.Equal("Thursday", GetDay(3));
        Assert.Equal("Friday", GetDay(4));
        Assert.Equal("Saturday", GetDay(5));
        Assert.Equal("Sunday", GetDay(6));
    }

    [Fact]
    public void PrintMonthTest()
    {
        //Console.WriteLine("This is the PrintDay Test Running.");
        Assert.Equal("January", GetMonth(0));
        Assert.Equal("February", GetMonth(1));
        Assert.Equal("March", GetMonth(2));
        Assert.Equal("April", GetMonth(3));
        Assert.Equal("May", GetMonth(4));
        Assert.Equal("June", GetMonth(5));
        Assert.Equal("July", GetMonth(6));
        Assert.Equal("August", GetMonth(7));
        Assert.Equal("September", GetMonth(8));
        Assert.Equal("October", GetMonth(9));
        Assert.Equal("November", GetMonth(10));
        Assert.Equal("December", GetMonth(11));
        
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
        string expected = "It is not January 1, 2000!\r\n";
        using (StringWriter wr = new())
        {
            Console.SetOut(wr);
            Y2KChecker.Check(DateTime.Now);
            string actual = wr.ToString();
            Assert.Equal(expected, actual);
        };
    }

    [Fact]
    public async void TestY2KCheckerThrowsAsync() {
        Func<Task> testCode = () => Task.Factory.StartNew(Y2KCheckerThrowingMethod);

        ApplicationException ex = await Assert.ThrowsAsync<ApplicationException>(testCode);

        Assert.IsType<ApplicationException>(ex);
    }

    [Fact]
    public void TestGetTomorrow(){
        DateTime tomorrow = DateTime.Now + new TimeSpan(1, 0, 0, 0);
        Assert.Equal(tomorrow.ToString("dd/MM/yyy"), GetTomorrow());
    }
    
    private void MonthThrowingMethod()
    {
        GetMonth(12);
    }

    private void DayThrowingMethod()
    {
        GetDay(7);
    }

    private void Y2KCheckerThrowingMethod()
    {
           Y2KChecker.Check(new DateTime(2000,1,1));
    }


}