using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Templatey.LightEnginev
{
    public class LightTemplateEngine : ITemplateEngine
    {
        public ITemplate Parse(
            ReadOnlyMemory<char> buffer,
            ParseContext context
        )
        {
            throw new NotImplementedException();
        }

        public ITemplate Parse(
            TextReader reader,
            ParseContext context
        )
        {
            throw new NotImplementedException();
        }

        public Task<ITemplate> ParseAsync(
            TextReader reader,
            ParseContext context,
            CancellationToken cancellationToken
        )
        {
            throw new NotImplementedException();
        }
    }
}