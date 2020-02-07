using System.Collections.Generic;

namespace Tabber.Core.Lexing
{
    public class Token
    {
        public Token()
        {
            
        }

        public Token(TokenType tokenType, string value)
        {
            TokenType = tokenType;
            Value = value;
        }

        public TokenType TokenType { get; set; }
        public string Value { get; set; }
    }
}