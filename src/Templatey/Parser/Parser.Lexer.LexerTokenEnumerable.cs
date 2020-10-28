using System.Collections;
using Templatey.Utilities;

namespace Templatey.Parser
{
    partial class Parser
    {
        partial class Lexer
        {
            internal class LexerTokenEnumerator : IPeekingEnumerator<Token>
            {
                public bool MoveNext()
                {
                    throw new System.NotImplementedException();
                }

                public void Reset()
                {
                    throw new System.NotImplementedException();
                }

                public Token Current { get; }

                object IEnumerator.Current => Current;

                public void Dispose()
                {
                    throw new System.NotImplementedException();
                }

                public Token Next { get; }

                public bool TryPeek(
                    out Token next
                )
                {
                    throw new System.NotImplementedException();
                }
            }
        }
    }
}