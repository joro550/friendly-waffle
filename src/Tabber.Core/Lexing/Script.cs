using System.Collections.Generic;

namespace Tabber.Core.Lexing
{
    public class Script
    {
        private readonly Queue<char> _scriptLetters;
        private string _currentLetter = string.Empty;

        public Script(string script)
            => _scriptLetters = new Queue<char>(script);

        public string Peek()
        {
            var hasValue = _scriptLetters.TryPeek(out var r);
            return hasValue ? r.ToString() : string.Empty;
        }

        public string Current()
            => _currentLetter;

        public string Next()
        {
            var result = _scriptLetters.TryDequeue(out var currentLetter);
            _currentLetter = result ? currentLetter.ToString() : string.Empty;
            return _currentLetter;
        }
    }
}