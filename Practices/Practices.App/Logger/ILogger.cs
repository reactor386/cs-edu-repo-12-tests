//-
using System;


namespace Practices.Logger;

/// <summary>
/// Интерфейс для реализации логгера
/// </summary>
public interface ILogger
{
    public void Event(string message);
    public void Error(string message);
}
