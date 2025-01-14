//-
using System;


namespace Practices;

/// <summary>
/// Исходный класс калькулятора для покрытия тестами
/// </summary>
public class Calculator
{
    public int Additional(int a, int b)
    {
        return a + b;
    }

    public int Subtraction(int a, int b)
    {
        return a - b;
    }

    public int Miltiplication(int a, int b)
    {
        return a * b;
    }

    public int Division(int a, int b)
    {
        return a / b;
    }
}
