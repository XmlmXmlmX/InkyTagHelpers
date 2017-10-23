namespace InkyTagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    /// <summary>
    /// Represents a Foundation for Email Menu.
    /// <see cref="https://foundation.zurb.com/emails/docs/menu.html"/>
    /// Use the menu component to create a horizontal or vertical list of links.
    /// </summary>
    [HtmlTargetElement(TagNames.MENU)]
    [OutputElementHint("table")]
    public class MenuTagHelper : TagHelper
    {
        /// <summary>
        /// Define your classes wich should be rendered for.
        /// </summary>
        [HtmlAttributeName("class")]
        public string CssClass { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string cssClass = CssClassNames.CALLOUT;

            if (!string.IsNullOrWhiteSpace(CssClass))
            {
                cssClass += $" {CssClass}";
            }

            output.TagName = "table";
            output.Attributes.Add("class", cssClass);
            output.PreContent.SetHtmlContent("<tr><td><table><tr>");
            output.PostContent.SetHtmlContent("</tr></table></td></tr>");
        }
    }
}
