//-
// using NUnit.Framework;
// using NUnit.Framework.Legacy;
using Moq;

using System;

using Practices;
using Practices.Logger;


namespace Practices.Tests;

/// <summary>
/// Тесты усеченного калькулятора с функцией деления и DI-параметром
/// В качестве DI-параметра используем mock-объект вместо реального объекта логгера
/// </summary>
[TestFixture]
public class DivideInspectorTests
{
    [Test]
    public void Divide_MustReturnCorrectValue()
    {
        Mock<ILogger> mock = new Mock<ILogger>();
        var divideInspector = new DivideInspector(mock.Object);

        Assert.That(divideInspector.Divide(6, 2), Is.EqualTo(3));
    }

    [Test]
    public void Division_MustThrowException()
    {
        Mock<ILogger> mock = new Mock<ILogger>();
        var divideInspector = new DivideInspector(mock.Object);

        Assert.Throws<DivideByZeroException>(() => divideInspector.Divide(6, 0));
    }
}
