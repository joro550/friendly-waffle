namespace Tabber.Core.Lexing
{
    public enum TokenType
    {
        None,
        
        Int,

        Let,
        Function,

        Identifier,
        Comma,

        EndOfScript,
        Illegal
    }
}