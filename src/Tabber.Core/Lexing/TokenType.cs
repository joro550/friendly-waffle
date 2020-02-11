namespace Tabber.Core.Lexing
{
    public enum TokenType
    {
        None,

        Int,
        Constant,

        Let,
        Function,

        Identifier,
        Comma,

        EndOfScript,
        Illegal
    }
}