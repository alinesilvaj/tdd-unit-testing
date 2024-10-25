using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImplementation _calc;
    public CalculadoraTests()
    {
        _calc = new CalculadoraImplementation();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(51, 17, 68)]
    public void MustSumTheFirstTwoAndReturnTheThird(int num1, int num2, int expectedResult)
    {
        int calculatorResult = _calc.Sum(num1, num2);

        Assert.Equal(expectedResult, calculatorResult);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(51, 17, 34)]
    public void MustSubtractTheFirstTwoAndReturnTheThird(int num1, int num2, int expectedResult)
    {
        int calculatorResult = _calc.Subtraction(num1, num2);

        Assert.Equal(expectedResult, calculatorResult);
    }

    [Theory]
    [InlineData(3, 3, 9)]
    [InlineData(12, 12, 144)]
    public void MustMultiplyTheFirstTwoAndReturnTheThird(int num1, int num2, int expectedResult)
    {
        int calculatorResult = _calc.Multiplication(num1, num2);

        Assert.Equal(expectedResult, calculatorResult);
    }

    [Theory]
    [InlineData(100, 10, 10)]
    [InlineData(2, 4, 0.5)]
    public void MustDivideTheFirstTwoAndReturnTheThird(double num1, double num2, double expectedResult)
    {
        double calculatorResult = _calc.Division(num1, num2);

        Assert.Equal(expectedResult, calculatorResult);
    }

    [Theory]
    [InlineData(10, 3, 1000)]
    [InlineData(3, 3, 27)]
    public void MustRaiseTheFirstByTheSecondAndReturnTheThird(double num1, double num2, double expectedResult)
    {
        double calculatorResult = _calc.Exponentiation(num1, num2);

        Assert.Equal(expectedResult, calculatorResult);
    }

    [Fact]
    public void TestDivisionByZero()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calc.Division(3, 0)
        );
    }

    [Fact]
    public void testHistory()
    {
        _calc.Sum(1, 2);
        _calc.Subtraction(9, 5);
        _calc.Multiplication(5, 6);
        _calc.Division(1, 1);

        var lista = _calc.history();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}