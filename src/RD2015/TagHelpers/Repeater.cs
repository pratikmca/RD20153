using Microsoft.AspNet.Razor.TagHelpers;
using System.Threading.Tasks;

namespace RD2015.TagHelpers
{
    [HtmlTargetElement(Attributes = "repeater")]
    public class RepeaterTagHelper : TagHelper
    {
        public int Count { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (Count <= 0)
                return;

            for (int i = 0; i < Count; i++)
            {
                var content = await output.GetChildContentAsync();
                output.Content.Append(content.ToString());
            }
        }

    }
}
