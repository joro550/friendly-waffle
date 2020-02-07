namespace Tabber.Core.Lexing
{
    public class Lexer
    {
        public Token[] Tokenize(string empty)
        {
            return new[]
            {
                new Token {TokenType = TokenType.Let}
            };
        }
    }
}