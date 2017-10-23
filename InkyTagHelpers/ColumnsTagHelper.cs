namespace InkyTagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System;
    
    [HtmlTargetElement(TagNames.COLUMNS, ParentTag = TagNames.ROW)]
    [OutputElementHint("th")]
    public class ColumnsTagHelper : TagHelper
    {
        /// <summary>
        /// Smallsize
        /// </summary>
        [HtmlAttributeName("small")]
        [MaxValue(Grid.MaxSize)]
        [MinValue(Grid.MinSize)]
        public int Small { get; set; } = Grid.MaxSize;

        /// <summary>
        /// Largesize
        /// </summary>
        [HtmlAttributeName("large")]
        [MaxValue(Grid.MaxSize)]
        [MinValue(Grid.MinSize)]
        public int Large { get; set; } = Grid.MaxSize;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "th";
            output.Attributes.Add("class", $"small-{Small} large-{Large} {CssClassNames.COLUMNS} first last");
            output.PreContent.SetHtmlContent("<table><tr><th>");
            output.PostContent.SetHtmlContent($"</th><th class='{CssClassNames.EXPANDER}'></th></tr></table>");
        }
    }

    public class MaxValue : Attribute
    {
        public int Max;

        public MaxValue(int max)
        {
            Max = max;
        }
    }

    public class MinValue : Attribute
    {
        public int Min;

        public MinValue(int min)
        {
            Min = min;
        }
    }
}