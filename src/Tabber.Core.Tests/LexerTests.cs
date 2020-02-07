using Xunit;
using Tabber.Core.Lexing;

namespace Tabber.Core.Tests
{
    public class LexerTests
    {
        [Theory]
        [InlineData("let", TokenType.Let)]
        public void WhenScriptContainsValidToken_ThenExpectedTokenTypeHasBeenPopulated(string script, TokenType expectedTokenType)
        {
            var lexer = new Lexer();
            var tokens = lexer.Tokenize(script);

            var token = Assert.Single(tokens);
            Assert.NotNull(token);
            Assert.Equal(expectedTokenType, token.TokenType);
        }
    }
}