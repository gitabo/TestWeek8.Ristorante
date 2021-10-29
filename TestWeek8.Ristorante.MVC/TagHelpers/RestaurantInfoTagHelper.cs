using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWeek8.Ristorante.MVC.Models;

namespace TestWeek8.Ristorante.MVC.TagHelpers
{
    public class RestaurantInfoTagHelper : TagHelper
    {
        public Restaurant Restaurant { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("itemscope itemtype", "http://schema.org/Organization");
            output.Content.SetHtmlContent(
            $@"<span itemprop=""name"">{Restaurant.Name}</span><br/>
            <address itemprop=""address"">
            <span itemprop=""streetAddress"">{Restaurant.StreetAddress}</span><br/>
            <span itemprop=""addressLocality"">{Restaurant.AddressLocality}</span><br/>
            <span itemprop=""streetRegion"">{Restaurant.AddressRegion}</span><br/>
            <span itemprop=""postalCode"">{Restaurant.PostalCode}</span><br/>
            <span itemprop=""email"">{Restaurant.Email}</span>");
            output.Attributes.SetAttribute("class", "row col-6");
        }
    }
}
