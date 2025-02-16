//-
// using NUnit.Framework;
// using NUnit.Framework.Legacy;
// using Moq;

using System;

using Practices;


namespace Practices.Tests;

/// <summary>
/// Тесты для исходного калькулятора по заданию
/// </summary>
[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Additional_MustReturnCorrectValue()
    {
        var calculator = new Calculator();
        Assert.That(calculator.Additional(2, 3), Is.EqualTo(5));
    }

    [Test]
    public void Subtraction_MustReturnCorrectValue()
    {
        var calculator = new Calculator();
        Assert.That(calculator.Subtraction(5, 2), Is.EqualTo(3));
    }

    [Test]
    public void Miltiplication_MustReturnCorrectValue()
    {
        var calculator = new Calculator();
        Assert.That(calculator.Miltiplication(3, 4), Is.EqualTo(12));
    }

    [Test]
    public void Division_MustReturnCorrectValue()
    {
        var calculator = new Calculator();
        Assert.That(calculator.Division(12, 3), Is.EqualTo(4));
    }

    [Test]
    public void Division_MustThrowException()
    {
      var calculator = new Calculator();
      Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
    }
}
