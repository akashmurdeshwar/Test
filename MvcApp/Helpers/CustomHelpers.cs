using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcApp.Helpers
{
    public static class CustomHelpers
    {
        // Example: Custom Red Label
        public static IHtmlContent RedLabel(this IHtmlHelper htmlHelper, string text)
        {
            string html = $"<label style='color:red; font-weight:bold'>{text}</label>";
            return new HtmlString(html);
        }

        // Example: Bootstrap-styled button
        public static IHtmlContent BootstrapButton(this IHtmlHelper htmlHelper, string text, string type = "primary")
        {
            string html = $"<button class='btn btn-{type}'>{text}</button>";
            return new HtmlString(html);
        }
    }
}
