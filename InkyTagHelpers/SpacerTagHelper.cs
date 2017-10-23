namespace InkyTagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement(TagNames.SPACER)]
    [OutputElementHint("table")]
    public class SpacerTagHelper : TagHelper
    {
        [HtmlAttributeName("size")]
        public int Size { get; set; } = 16;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "table";
            output.Attributes.Add("class", "spacer");
            output.Content.SetHtmlContent($@"<tbody><tr><td height='{Size}px' style='font-size:{Size}px;line-height:{Size}px;#'>&#xA0;</td></tr></tbody>");
            output.PostContent.SetHtmlContent("</tr></tbody>");
        }
    }
}
