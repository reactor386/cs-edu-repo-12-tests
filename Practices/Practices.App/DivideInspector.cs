//-
using System;

using Practices.Logger;


namespace Practices;

/// <summary>
/// Реализация усеченного калькулятора с единственной функцией деления
///  и DI-параметром для примера использования mock-объектов в тестах
/// </summary>
public class DivideInspector
{
    ILogger _logger;

    /// <summary>
    /// Конструктор принимает DI параметр
    /// </summary>
    /// <param name="logger"></param>
    public DivideInspector(ILogger logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Функция деления, записывает сообщения в логгер
    /// </summary>
    /// <param name="a">число</param>
    /// <param name="b">число</param>
    /// <returns>результат деления первого аргумента на второй</returns>
    /// <exception cref="DivideByZeroException">возникает, если второй аргумент равен 0</exception>
    public int Divide(int a, int b)
    {
        int res;
        _logger.Event("division started");

        if (b == 0)
        {
            _logger.Error("division error");
            throw new DivideByZeroException("wrong argument");
        }

        res = a / b;

        _logger.Event("division stopped");
        return res;
    }
}
