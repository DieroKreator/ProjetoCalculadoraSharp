using NUnit.Framework;
using Calc;

namespace Calculadora139Sharp.Tests;

public class Tests
{
    // private Calculadora _calculadora;
    [SetUp]
    public void Setup()
    {
        // _calculadora = new Calculadora(); // instancia o objeto
    }

    [Test]
    public void testSomarDoisNumeros()
    {
        // Triple A = AAA

        int num1 = 15;
        int num2 = 35;

        int resultadoEsperado =50;

        int resultadoAtual = Calculadora.SomarDoisNumero(num1, num2);

        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }
}