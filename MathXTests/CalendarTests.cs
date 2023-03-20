namespace MathXTests;

using myMath;
using static myMath.Calendars;
using System;



public class CalendarTests
{
    [Fact]
    public void PrintDayTest() 
    {
        Calendars calendars = new();
        Assert.Equal("Monday", calendars.GetDay(0));
        Assert.Equal("Tuesday", calendars.GetDay(1));
        Assert.Equal("Wednesday", calendars.GetDay(2));
        Assert.Equal("Thursday", calendars.GetDay(3));
        Assert.Equal("Friday", calendars.GetDay(4));
        Assert.Equal("Saturday", calendars.GetDay(5));
        Assert.Equal("Sunday", calendars.GetDay(6));
    }

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
           Y2KChecker.Check(new DateTime(2000,1,1));
    }


}