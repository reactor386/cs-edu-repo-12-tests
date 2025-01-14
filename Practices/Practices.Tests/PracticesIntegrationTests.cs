//-
// using NUnit.Framework;
// using NUnit.Framework.Legacy;
// using Moq;

using System;

using Practices;
using Practices.Logger;


namespace Practices.Tests;

/// <summary>
/// Интеграционные тесты для вызова двух калькуляторов
/// Для интеграционных тестов не используем mock-объект
/// </summary>
[TestFixture]
public class PracticesIntegrationTests
{
    [Test]
    public void CalculatorAndInspectorMustReturnCorrectValues()
    {
        var calculator = new Calculator();

        Assert.That(calculator.Additional(2, 3), Is.EqualTo(5));
        Assert.That(calculator.Subtraction(5, 2), Is.EqualTo(3));
        Assert.That(calculator.Miltiplication(3, 4), Is.EqualTo(12));
        Assert.That(calculator.Division(12, 3), Is.EqualTo(4));
        Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));

        ILogger logger = new Logger.Logger();
        var divideInspector = new DivideInspector(logger);

        Assert.That(divideInspector.Divide(6, 2), Is.EqualTo(3));
        Assert.Throws<DivideByZeroException>(() => divideInspector.Divide(6, 0));
    }
}
