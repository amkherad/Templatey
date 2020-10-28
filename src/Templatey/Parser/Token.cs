namespace Templatey.Parser
{
    internal struct Token
    {
        public TokenSource Source { get; set; }
        
        public TokenCursor Cursor { get; set; }
        
        
    }
}