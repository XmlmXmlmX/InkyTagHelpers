namespace InkyTagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement(TagNames.WRAPPER)]
    [OutputElementHint("table")]
    public class WrapperTagHelper : TagHelper
    {
        /// <summary>
        /// Define your classes wich should be rendered for the inner td element.
        /// </summary>
        [HtmlAttributeName("class")]
        public string CssClass { get; set; }

        /// <summary>
        /// Define your classes wich should be rendered for.
        /// </summary>
        [HtmlAttributeName("table-class")]
        public string TableCssClass { get; set; }

        [HtmlAttributeName("align")]
        public Align Align { get; set; } = Align.center;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string tableCssClass = CssClassNames.WRAPPER;

            if (!string.IsNullOrWhiteSpace(TableCssClass))
            {
                tableCssClass += $" {TableCssClass}";
            }

            string cssClass = CssClassNames.WRAPPER_INNER;

            if (!string.IsNullOrWhiteSpace(CssClass))
            {
                cssClass += $" {CssClass}";
            }
            
            output.TagName = "table";
            output.Attributes.Add("class", tableCssClass);
            output.PreContent.SetHtmlContent($"<tr><td class='{cssClass}'>");
            output.PostContent.SetHtmlContent("</td></tr>");
        }
    }
}
