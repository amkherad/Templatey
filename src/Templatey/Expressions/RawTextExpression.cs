using System;

namespace Templatey.Expressions
{
    public abstract class RawTextExpression : AstExpression
    {
        public static RawTextExpression Create(
            ReadOnlyMemory<char> str
        )
        {
            return new ReadOnlySpanExpression(str);
        }
        
        public static RawTextExpression Create(
            string str
        )
        {
            return new InMemoryStringExpression();
        }
    }

    public class InMemoryStringExpression : RawTextExpression
    {
        
    }

    public class ReadOnlySpanExpression : RawTextExpression
    {
        private readonly ReadOnlyMemory<char> _str;

        public ReadOnlySpanExpression(
            ReadOnlyMemory<char> str
        )
        {
            _str = str;
        }
    }
}