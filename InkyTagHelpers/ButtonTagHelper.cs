namespace InkyTagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    /// <summary>
    /// <see cref="https://foundation.zurb.com/emails/docs/button.html"/>
    /// </summary>
    [HtmlTargetElement(TagNames.BUTTON)]
    [OutputElementHint("a")]
    public class ButtonTagHelper : TagHelper
    {
        /// <summary>
        /// The buttons URL.
        /// </summary>
        [HtmlAttributeName("href")]
        public string Href { get; set; } = "#";

        /// <summary>
        /// Define your classes wich should be rendered.
        /// Note that the class "button" will be added by default.
        /// Possible foundation for emails classes for buttons:
        /// </summary>
        /// <example>tiny, small, large</example>
        [HtmlAttributeName("class")]
        public string CssClass { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string cssClass = CssClassNames.BUTTON;

            if (!string.IsNullOrWhiteSpace(CssClass))
            {
                cssClass += $" {CssClass}";
            }

            output.TagName = "table";
            output.Attributes.Add(context.AllAttributes.ToList());
            output.Attributes.RemoveAttribute("href");
            output.Attributes.SetAttribute("class", cssClass);
            output.PreContent.SetHtmlContent($@"<tr><td><table><tr><td><a href='{Href}'>");
            output.PostContent.SetHtmlContent("</a></td></tr></table></td></tr>");
        }
    }
}
