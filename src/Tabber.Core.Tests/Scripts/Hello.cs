using System;
using System.Collections.Generic;
using System.Text;
using Tabber.Core.Lexing;

namespace Tabber.Core.Tests.Scripts
{
    class Hello
    {
        public static List<TokenType> H()
        {
            return new List<TokenType>
            {
                // section
                TokenType.Function,
                TokenType.Identifier,

                // variable
                TokenType.Let,
                TokenType.Identifier,
                TokenType.Eq,

                // chord
                TokenType.Constant,
                TokenType.Int,
                TokenType.Constant,
                TokenType.Int,
                TokenType.Constant,
                TokenType.Int,
                TokenType.Constant,
                TokenType.Int,
                TokenType.Constant,
                TokenType.Int,
                TokenType.Constant,
                TokenType.Int,

                //repeat
                TokenType.Identifier,
                TokenType.Int,

                //play open a
                TokenType.Identifier,
                TokenType.Constant,

                //play chord
                TokenType.Identifier,
                TokenType.Identifier,

                //play wait
                TokenType.Identifier,
                TokenType.Constant,

                //main
                TokenType.EntryPoint,

                //play section
                TokenType.Identifier,
                TokenType.Identifier,

                TokenType.EndOfScript
            };
        }
    }
}
