using Microsoft.AspNetCore.Razor.TagHelpers;

namespace InkyTagHelpers
{
    public static class TagHelperAttributeExtensions
    {
        public static void Add(this TagHelperAttributeList tagHelperAttributeList, TagHelperAttributeList newTagHelperAttributeList)
        {
            foreach (TagHelperAttribute attr in newTagHelperAttributeList)
            {
                tagHelperAttributeList.Add(attr);
            }
        }

        public static TagHelperAttributeList ToList(this ReadOnlyTagHelperAttributeList readOnlyTagHelperAttributeList)
        {
            TagHelperAttribute[] attrs = new TagHelperAttribute[readOnlyTagHelperAttributeList.Count];

            readOnlyTagHelperAttributeList.CopyTo(attrs, 0);

            return new TagHelperAttributeList(attrs);
        }

        public static void RemoveAttribute(this TagHelperAttributeList tagHelperAttributeList, string name)
        {
            foreach (TagHelperAttribute attr in tagHelperAttributeList)
            {
                if (attr.Name == name)
                {
                    tagHelperAttributeList.Remove(attr);

                    break;
                }
            }
        }
    }
}
