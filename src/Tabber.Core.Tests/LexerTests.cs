using Xunit;
using System.Linq;
using Tabber.Core.Lexing;
using Tabber.Core.Tests.Scripts;
using static Tabber.Core.Tests.Scripts.Loader;

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

        [Fact]
        public void GivenAScript_WithAllValidTokens_ThenListOfTokens()
        {
            var script = LoadFileContents(SimpleScript);
            var tokens = Lexer.Tokenize(script);
            var expectedTokens = Hello.H();
            Assert.Equal(expectedTokens, tokens.Select(token => token.TokenType));
        }
    }
}