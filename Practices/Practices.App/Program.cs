// -
using System;


namespace Practices.App;

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

        Console.WriteLine("---");
        Console.WriteLine($"return: [{result}]");
        Console.ReadKey();
    }
}
