using Xunit;
using myMath;
using System;

namespace MathXTests;
public class HelpersTests
{
    [Fact]
    public void Divide_DivisorNotZero_ReturnsQuotient()
    {
        var helpers = new Helpers();
        var result = helpers.Divide(10, 2);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_DivisorZero_ThrowsException()
    {
        var helpers = new Helpers();
        Assert.Throws<ArgumentOutOfRangeException>(testCode: () => helpers.Divide(10, 0));
    }

    [Fact]
    public void GetOption_ValidInput_ReturnsNumber()
    {
		using StringReader reader = new("1");
		Console.SetIn(reader);
		int result = Helpers.GetOption("This doesn't matter:");
		Assert.Equal(1, result);
    }

    [Fact]
    public void GetOption_InvalidInput_ReturnsZero()
    {
        using StringReader reader = new("invalid");
        Console.SetIn(reader);
        var result = Helpers.GetOption("This text doesn't matter.");
        Assert.Equal(0, result);
    }

    [Fact]
    public void SelectOperation_ReturnsOperation()
    {
        using StringReader reader = new("1");
        Console.SetIn(reader);
        var result = Helpers.SelectOperation();
        Assert.InRange(result, 0, 4);
    }

    [Fact]
    public void PerformAnOperation_ValidOperation_ReturnsResult()
    {
        var result = Helpers.PerformAnOperation(1, 2);
        Assert.Equal(4, result);
    }

    [Fact]
    public void NewMethod_ReturnsHelloWorld()
    {
        var result = Helpers.NewMethod();
        Assert.Equal("Hello World", result);
    }

    [Fact]
    public void DoSomething2_ValidInputs_ReturnsTrue()
    {
        var result = Helpers.ValidateAndCompareNumbers(10, 2);
        Assert.True(result);
    }

    [Fact]
    public void DoSomething2_InvalidInputs_ReturnsFalse()
    {
        var result = Helpers.ValidateAndCompareNumbers(10, 0);
        Assert.False(result);
    }

    [Fact]
    public void GetNumberInput_ValidInput_ReturnsNumber()
    {
        var result = Helpers.GetNumberInput("1");
        Assert.Equal(1, result);
    }

    [Fact]
    public void GetNumberInput_InvalidInput_ReturnsZero()
    {
        var result = Helpers.GetNumberInput("invalid");
        Assert.Equal(0, result);
    }
}