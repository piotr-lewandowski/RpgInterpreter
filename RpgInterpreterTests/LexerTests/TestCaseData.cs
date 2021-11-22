﻿using System.Collections.Generic;
using System.Linq;
using RpgInterpreter.Lexer;
using RpgInterpreter.Lexer.Sources;
using RpgInterpreter.Tokens;

namespace RpgInterpreterTests.LexerTests
{
    public record SingleTestData(string Input, Token Output)
    {
        public StringSource Source => new StringSource(Input);
    }


    public record ListTestData(string Input, IEnumerable<Token> Output)
    {
        public ListTestData(string input, Token output) : this(input, new[] { output }) { }
        public StringSource Source => new StringSource(Input);

    }
}