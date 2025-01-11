namespace MathXTests;
using myMath;

public class VariousXUnitTests
{
    [Fact]
    public void PrintMonthTest()
    {
        Console.WriteLine("This is the Print Month Test Running.");
        Calendars calendars = new();
        Assert.Equal("January", Calendars.GetMonth(0));
        Assert.Equal("February", Calendars.GetMonth(1));
        Assert.Equal("March", Calendars.GetMonth(2));
        Assert.Equal("April", Calendars.GetMonth(3));
        Assert.Equal("May", Calendars.GetMonth(4));
        Assert.Equal("June", Calendars.GetMonth(5));
        Assert.Equal("July", Calendars.GetMonth(6));
        Assert.Equal("August", Calendars.GetMonth(7));
        Assert.Equal("September", Calendars.GetMonth(8));
        Assert.Equal("October", Calendars.GetMonth(9));
        Assert.Equal("November", Calendars.GetMonth(10));
        Assert.Equal("December", Calendars.GetMonth(11));

    }

    [Fact]
    public async Task MonthThrowsAsync()
    {
        Calendars calendars = new();
        Task testCode() => Task.Factory.StartNew(ThrowingMethod);

        var ex = await Assert.ThrowsAsync<ArgumentOutOfRangeException>(testCode);

        Assert.IsType<ArgumentOutOfRangeException>(ex);
    }

    void ThrowingMethod()
    {
        Calendars calendars = new();
        Calendars.GetMonth(12);
    }

    [Fact]
    public void DoSomething2_ValidParams_ReturnsTrue()
    {
        // Arrange
        var simpleMathMock = new Mock<Helpers>();
        int a = 10, b = 2;
        simpleMathMock.Setup(x => x.Divide(a, b)).Returns(a / b);

        // Act
        bool result = myMath.Helpers.ValidateAndCompareNumbers(a, b);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void DoSomething2_InvalidParams_ReturnsFalse()
    {
        // Arrange
        var simpleMathMock = new Mock<Helpers>();
        int a = 10, b = 0;
        simpleMathMock.Setup(x => x.Divide(a, b)).Throws(new ArgumentOutOfRangeException());

        // Act
        bool result = myMath.Helpers.ValidateAndCompareNumbers(a, b);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void DoSomething2_ValidInput()
    {
        // Act
        bool result = myMath.Helpers.ValidateAndCompareNumbers(1, 1);

        // Assert
        Assert.True(result);
    }

}