using Xunit;
using NewTalents;

namespace MyProject.Tests;

public class UnitTest1
{

    public Calculadora calculadoraInit()
    {
        DateTime data = DateTime.Now;
        Calculadora calc = new Calculadora(data);

        return calc;
    }


    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 7, 11)]
    public void TestSoma(int num1, int num2, int result)
    {
        Calculadora calc = calculadoraInit();

        int calcResult = calc.somar(num1, num2);

        Assert.Equal(result, calcResult);

    }

    [Theory]
    [InlineData(5, 2, 3)]
    [InlineData(18, 7, 11)]
    public void TestSubtracao(int num1, int num2, int result)
    {
        Calculadora calc = calculadoraInit();

        int calcResult = calc.subtrair(num1, num2);

        Assert.Equal(result, calcResult);

    }

    [Theory]
    [InlineData(1, 3, 3)]
    [InlineData(5, 2, 10)]
    public void TestMultiplicacao(int num1, int num2, int result)
    {
        Calculadora calc = calculadoraInit();
        int calcResult = calc.multiplicar(num1, num2);

        Assert.Equal(result, calcResult);

    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(77, 7, 11)]
    public void TestDivisao(int num1, int num2, int result)
    {
        Calculadora calc = calculadoraInit();
        int calcResult = calc.dividir(num1, num2);

        Assert.Equal(result, calcResult);

    }

    [Fact]
    public void TestDivisaoPorZero()
    {
        Calculadora calc = calculadoraInit();

        Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));

    }

    [Fact]
    public void TestMemory()
    {
        Calculadora calc = calculadoraInit();

        calc.somar(1, 2);
        calc.somar(2, 2);
        calc.somar(4, 2);
        calc.somar(5, 2);

        var lista = calc.memory();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);

    }


}