using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagHealper.TagHeapers
{
    public class ShayesteTagHelper : TagHelper
    {

        public string UserName { get; set; }
        public List<string> Users { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (Users.Contains(UserName))
            {
                output.TagName = "p";
                output.Attributes.Add("class","alert alert-danger") ;
            }
            else
            {
                output.SuppressOutput();
            }
        }
    }
}
