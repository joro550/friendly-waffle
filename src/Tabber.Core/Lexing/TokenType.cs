namespace Tabber.Core.Lexing
{
    public enum TokenType
    {
        None,

        Int,
        Constant,

        Let,
        Function,
        Eq,

        Identifier,
        Comma,

        EntryPoint,

        EndOfScript,
        Illegal,
    }
}