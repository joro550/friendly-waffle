using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tabber.Core.Lexing
{
    public static class Lexer
    {
        private static readonly Dictionary<string, TokenType> Keywords = new Dictionary<string, TokenType>
        { 
            {"section", TokenType.Function},
            {"let", TokenType.Let},
        };

        public static IEnumerable<Token> Tokenize(string scriptContent)
        {
            var script = new Script(scriptContent);
            var tokens = new List<Token>();

            var currentToken = script.Next();

            while (!script.IsEndOfScript())
            {
                tokens.Add(ParseToken(currentToken, script));

                currentToken = script.Next();
            }

            tokens.Add(new Token(TokenType.EndOfScript, string.Empty));
            return tokens;
        }

        private static Token ParseToken(string currentToken, Script script)
        {
            if (currentToken.Length < 1)
                return Token(TokenType.Illegal, string.Empty);

            switch (currentToken)
            {
                case ",":
                    return Token(TokenType.Comma, currentToken);
                default:
                    {
                        var identifier = script.Current();

                        if (int.TryParse(identifier, out _))
                            return GetNumber(script, identifier);

                        if (!Regex.IsMatch(identifier, "[a-zA-Z]"))
                            return Token(TokenType.Illegal, string.Empty);

                        while (Regex.IsMatch(script.Peek(), "[a-zA-Z]"))
                            identifier += script.Next();

                        return Token(Keywords.ContainsKey(identifier)
                            ? Keywords[identifier]
                            : TokenType.Identifier, identifier);
                    }
            }
        }

        private static Token GetNumber(Script script, string identifier)
        {
            while (int.TryParse(script.Peek(), out _))
                identifier += script.Next();
            return Token(TokenType.Int, identifier);
        }


        private static Token Token(TokenType tokenType, string value)
            => new Token(tokenType, value);
    }
}