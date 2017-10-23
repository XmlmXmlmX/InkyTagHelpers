namespace InkyTagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;
    
    [HtmlTargetElement(TagNames.ROW)]
    [OutputElementHint("table")] // Conflict with ParentTag
    public class RowTagHelper : TagHelper
    {
        /// <summary>
        /// Define your classes wich should be rendered.
        /// Note that the class "row" will be added by default.
        /// </summary>
        [HtmlAttributeName("class")]
        public string CssClass { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string cssClass = CssClassNames.ROW;

            if (!string.IsNullOrWhiteSpace(CssClass))
            {
                cssClass += $" {CssClass}";
            }

            output.TagName = "table";
            output.Attributes.Add("class", cssClass);
            output.PreContent.SetHtmlContent("<tbody><tr>");
            output.PostContent.SetHtmlContent("</tr></tbody>");
        }
    }
}
