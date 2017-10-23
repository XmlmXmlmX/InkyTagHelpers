namespace InkyTagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    /// <summary>
    /// Represents a Foundation for Email Menu Item.
    /// <see cref="https://foundation.zurb.com/emails/docs/menu.html"/>
    /// </summary>
    [HtmlTargetElement(TagNames.MENUITEM, ParentTag = TagNames.MENU)]
    [OutputElementHint("th")]
    public class MenuItemTagHelper : TagHelper
    {
        /// <summary>
        /// Define your classes wich should be rendered for.
        /// </summary>
        [HtmlAttributeName("class")]
        public string CssClass { get; set; }

        /// <summary>
        /// The Menuitems Link URL
        /// </summary>
        public string Href { get; set; } = "#";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string cssClass = CssClassNames.MENUITEM;

            if (!string.IsNullOrWhiteSpace(CssClass))
            {
                cssClass += $" {CssClass}";
            }

            output.TagName = "th";
            output.Attributes.Add("class", cssClass);
            output.PreContent.SetHtmlContent($@"<a href='{Href}'>");
            output.PostContent.SetHtmlContent("</a>");
        }
    }
}
