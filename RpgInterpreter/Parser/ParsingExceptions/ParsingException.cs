﻿namespace RpgInterpreter.Parser.ParsingExceptions;

public class ParsingException : Exception
{
    public ParsingException(string message) : base(message) { }
    public ParsingException() { }
}