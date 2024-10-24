using NUnit.Framework;
using Calc;

namespace Calculadora139Sharp.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void testSomarDoisNumeros()
    {
        // Triple A = AAA

        int num1 = 15;
        int num2 = 35;

        int resultadoEsperado = 50;

        int resultadoAtual = Calculadora.SomarDoisNumero(num1, num2);

        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }

    [Test]
    public void testSubtrairDoisNumeros()
    {
        int num1 = 20;
        int num2 = 8;

        int resultadoEsperado = 12;

        int resultadoAtual = Calculadora.SubtrairDoisNumeros(num1, num2);

        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }

    [Test]
    public void testMultiplicarDoisNumeros()
    {
        int num1 = 20;
        int num2 = 1;

        int resultadoEsperado = 20;

        int resultadoAtual = Calculadora.MultiplicarDoisNumeros(num1, num2);

        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }

    [Test]
    public void testDividirDoisNumeros()
    {
        int num1 = 20;
        int num2 = 4;

        int resultadoEsperado = 5;

        int resultadoAtual = Calculadora.DividirDoisNumeros(num1, num2);

        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }

    [Test]
    public void testDividirPorZero()
    {
        int num1 = 20;
        int num2 = 0;

        int resultadoEsperado = 0;

        int resultadoAtual = Calculadora.DividirDoisNumeros(num1, num2);

        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }
}