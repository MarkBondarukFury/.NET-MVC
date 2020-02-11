using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public static class ListHelpers
    {
        public static MvcHtmlString CreateUnorderedList(this HtmlHelper html, string[] items, string name)
        {
            var text = new TagBuilder("p");
            text.SetInnerText(name);
            var list = new TagBuilder("ul");
            foreach (string item in items)
            {
                var elem = new TagBuilder("li");
                elem.SetInnerText(item);
                list.InnerHtml += elem.ToString(); 
            }
            text.InnerHtml += list.ToString();
            return new MvcHtmlString(text.ToString());
        }
        public static MvcHtmlString CreateOrderedList(this HtmlHelper html, string[] items, string name)
        {
            var text = new TagBuilder("p");
            text.SetInnerText(name);
            var list = new TagBuilder("ol");
            foreach (string item in items)
            {
                var elem = new TagBuilder("li");
                elem.SetInnerText(item);
                list.InnerHtml += elem.ToString();
            }
            text.InnerHtml += list.ToString();
            return new MvcHtmlString(text.ToString());
        }
    }
}