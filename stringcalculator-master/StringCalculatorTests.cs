
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData ("1",1)]
    [InlineData ("2",2)]
    [InlineData ("192",192)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData ("1,2",3)]
    [InlineData ("3,4",7)]
    [InlineData ("42, 23", 65)]
    public void TwoNumbers(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData ("4,8,15,16,23,42", 108)]
    [InlineData ("3,5,9,7", 24)]
    [InlineData ("1000,2000,3000", 6000)]
    public void MultipleNumbers(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void NewLines()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("1\n2");

        Assert.Equal(3, result);
    }

    [Fact]
    public void CommaNewLineCombo()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("4,5\n7");

        Assert.Equal(16, result);
    }

    [Fact]
    public void CustomDelimiter()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("//;\n1,2");

        Assert.Equal(3, result);
    }
}
