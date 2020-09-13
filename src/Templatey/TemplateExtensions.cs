namespace Templatey
{
    public static class TemplateExtensions
    {
        public static string Render(
            this ITemplate template
        )
        {
            return Render(template, null);
        }
        
        public static string Render(
            this ITemplate template,
            TemplateContext context
        )
        {
            return string.Empty;
        }

        
        public static ITemplate Compile(
            this ITemplate template
        )
        {
            return template;
        }
    }
}