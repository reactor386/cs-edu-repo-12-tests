//-
using System;


namespace Practices.Logger;

/// <summary>
/// Реализация логгера
/// </summary>
public class Logger : ILogger
{
    public void Event(string message)
    {
        Console.WriteLine("msg:" + message);
    }

    public void Error(string message)
    {
        Console.WriteLine("err:" + message);
    }
}
