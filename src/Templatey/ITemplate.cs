using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Templatey
{
    public interface ITemplate
    {
        void Render(
            TextWriter writer,
            TemplateContext context
        );

        Task RenderAsync(
            TextWriter writer,
            TemplateContext context,
            CancellationToken cancellationToken
        );
    }
}