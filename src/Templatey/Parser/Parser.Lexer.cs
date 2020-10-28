using System.Collections;
using System.Collections.Generic;

namespace Templatey.Parser
{
    partial class Parser
    {
        protected internal partial class Lexer : IEnumerable<Token>
        {
            private string _sourceString;

            private int _length;
            private int _cursor;
            private Token[] _tokenPool = new Token[10];

            public Lexer()
            {
                
            }
        
            internal LexerTokenEnumerator Read()
            {
                return new LexerTokenEnumerator();
            }

            IEnumerator<Token> IEnumerable<Token>.GetEnumerator() => Read();

            IEnumerator IEnumerable.GetEnumerator() => Read();
        }
    }
}