using System;
class TemperatureOutOfRangeException : Exception
{
    public TemperatureOutOfRangeException() : base() { }
    public TemperatureOutOfRangeException(string message) : base(message) { }
    public TemperatureOutOfRangeException(string message, Exception inner) : base(message, inner) { }
}