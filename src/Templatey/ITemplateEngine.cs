using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Templatey
{
    public interface ITemplateEngine
    {
        ITemplate Parse(
            ReadOnlySpan<char> buffer,
            ParseContext context
        );
        
        ITemplate Parse(
            TextReader reader,
            ParseContext context
        );
        
        Task<ITemplate> ParseAsync(
            TextReader reader,
            ParseContext context,
            CancellationToken cancellationToken
        );
    }
}