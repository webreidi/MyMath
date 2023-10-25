namespace MathXTests;
using myMath;

public class VariousXUnitTests
{
    [Fact]
    public void PrintMonthTest()
    {
        Console.WriteLine("This is the PrintDay Test Running.");
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
        Calendars calendars = new();
        Func<Task> testCode = () => Task.Factory.StartNew(ThrowingMethod);

        var ex = await Assert.ThrowsAsync<ArgumentOutOfRangeException>(testCode);

        Assert.IsType<ArgumentOutOfRangeException>(ex);
    }

    void ThrowingMethod()
    {
        Calendars calendars= new();
        calendars.GetMonth(12);
    }

    [Fact]
    public void DoSomething2_ValidParams_ReturnsTrue()
    {
        // Arrange
        var simpleMathMock = new Mock<Helpers>();
        int a = 10, b = 2;
        simpleMathMock.Setup(x => x.Divide(a, b)).Returns(a / b);
 
        // Act
        bool result = Helpers.DoSomething2(a, b);

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
        bool result = Helpers.DoSomething2(a, b);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void DoSomething2_ValidAndInvalidDateStrings_FormatsDate()
    {
        // Arrange
        var simpleMathMock = new Mock<SimpleMath>();

        // Act
        bool result = Helpers.DoSomething2(1, 1);

        // Assert
        Assert.NotNull(result);
    }

}