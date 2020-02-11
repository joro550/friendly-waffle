﻿using System.Linq;
using Xunit;
using Tabber.Core.Lexing;

namespace Tabber.Core.Tests
{
    public class LexerTests
    {
        [Theory]
        [InlineData("let", TokenType.Let)]
        [InlineData("section", TokenType.Function)]
        [InlineData(",", TokenType.Comma)]
        [InlineData(":e", TokenType.Constant)]
        [InlineData("MyNewChord", TokenType.Identifier)]
        [InlineData("My_sNewChord", TokenType.Identifier)]
        public void WhenScriptContainsValidToken_ThenExpectedTokenTypeHasBeenPopulated(string script, TokenType expectedTokenType)
        {
            var tokens = Lexer.Tokenize(script);

            var token = tokens.FirstOrDefault();
            Assert.NotNull(token);
            Assert.Equal(expectedTokenType, token.TokenType);
            Assert.Equal(script, token.Value);
        }
    }
}