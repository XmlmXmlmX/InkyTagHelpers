namespace InkyTagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement(TagNames.CALLOUT)]
    [OutputElementHint("table")]
    public class CalloutTagHelper : TagHelper
    {
        /// <summary>
        /// Define your classes wich should be rendered for.
        /// </summary>
        [HtmlAttributeName("class")]
        public string CssClass { get; set; }

        /// <summary>
        /// Define your classes wich should be rendered for the inner callout.
        /// </summary>
        [HtmlAttributeName("table-class")]
        public string TableCssClass { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string tableCssClass = CssClassNames.CALLOUT;

            if (!string.IsNullOrWhiteSpace(TableCssClass))
            {
                tableCssClass += $" {TableCssClass}";
            }

            string cssClass = CssClassNames.CALLOUT_INNER;

            if (!string.IsNullOrWhiteSpace(CssClass))
            {
                cssClass += $" {CssClass}";
            }

            output.TagName = "table";
            output.Attributes.Add("class", tableCssClass);
            output.PreContent.SetHtmlContent($"<tbody><tr><th class='{cssClass}'>");
            output.PostContent.SetHtmlContent($"</th><th class='{CssClassNames.EXPANDER}'></th></tr></tbody>");
        }
    }
}
