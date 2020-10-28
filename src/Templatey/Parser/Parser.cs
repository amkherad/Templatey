using System.Collections;
using System.Collections.Generic;
using Templatey.Expressions;
using Templatey.Utilities;

namespace Templatey.Parser
{
    public partial class Parser //: IPeekingEnumerator<AstExpression>
    {
        protected internal readonly Lexer _Lexer;
        
        
        public Parser()
        {
            _Lexer = new Lexer();
        }


        IEnumerable<AstExpression> Read()
        {
            yield return null;
        }
        
        //
        // public IEnumerator<AstExpression> GetEnumerator()
        // {
        //     throw new System.NotImplementedException();
        // }
        //
        // IEnumerator IEnumerable.GetEnumerator() => Read();
    }
}