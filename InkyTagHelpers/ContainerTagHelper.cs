namespace InkyTagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement(TagNames.CONTAINER)]
    [OutputElementHint("table")]
    public class ContainerTagHelper : TagHelper
    {
        /// <summary>
        /// Define your classes wich should be rendered.
        /// </summary>
        [HtmlAttributeName("class")]
        public string CssClass { get; set; }

        [HtmlAttributeName("align")]
        public Align Align { get; set; } = Align.center;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string cssClass = CssClassNames.CONTAINER;

            if (!string.IsNullOrWhiteSpace(CssClass))
            {
                cssClass += $" {CssClass}";
            }

            output.TagName = "table";
            output.Attributes.Add("align", Align);
            output.Attributes.Add("class", cssClass);
            output.PreContent.SetHtmlContent("<tbody><tr><td>");
            output.PostContent.SetHtmlContent("</td></tr></tbody>");
        }
    }
}
