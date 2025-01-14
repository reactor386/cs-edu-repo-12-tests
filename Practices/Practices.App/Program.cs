// -
using System;

using Practices.Logger;


namespace Practices.App;

/// <summary>
/// Демонстрация выполнения
/// Сначала запускаем на выполнение исходный калькулятор из задания
/// Затем запускаем на выполнение усеченный калькулятор с функцией деления
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculator");
        Console.WriteLine("---");
        int result = 0;

        var calculator = new Calculator();

        Console.WriteLine($"Additional: 1+2={calculator.Additional(1, 2)}");
        Console.WriteLine($"Subtraction: 3-2={calculator.Subtraction(3, 2)}");
        Console.WriteLine($"Miltiplication: 2*3={calculator.Miltiplication(2, 3)}");
        Console.WriteLine($"Division: 4/2={calculator.Division(4, 2)}");

        Console.WriteLine();

        Console.WriteLine("DivideInspector");
        Console.WriteLine("---");

        ILogger logger = new Logger.Logger();
        var divideInspector = new DivideInspector(logger);

        Console.WriteLine($"Divide: 6/2={divideInspector.Divide(6, 2)}");

        try
        {
            Console.WriteLine($"Divide: 6/0={divideInspector.Divide(6, 0)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in Division catched: {ex.Message}");
        }

        Console.WriteLine("---");
        Console.WriteLine($"return: [{result}]");
        Console.ReadKey();
    }
}
