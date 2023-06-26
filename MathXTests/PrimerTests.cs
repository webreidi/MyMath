using myMath;
namespace MathXTests;

public class PrimerTests
{
    [Fact]
    public void Primer_OneShouldBeFalse()
    {
        Primer primer = new();
        Assert.False(primer.IsPrime(1));
    }

    [Fact]
    public void Primer_TwoShouldBeTrue()
    {
        Primer primer = new();
        Assert.True(primer.IsPrime(2));
    }

    [Fact]
    public void Primer_ThreeShouldBeTrue()
    {
        Primer primer = new();
        Assert.True(primer.IsPrime(3));
    }

    [Fact]
    public void Primer_FourShouldBeFalse()
    {
        Primer primer = new();
        Assert.False(primer.IsPrime(4));
    }

    [Fact]
    public void Primer_17ShouldBeTrue() 
    {
        Primer primer = new();
        Assert.True(primer.IsPrime(17));
    }

    [Fact]
    public void Primer_ZeroShouldBeFalse()
    {
        Primer primer = new();
        Assert.False(primer.IsPrime(0));
    }
}