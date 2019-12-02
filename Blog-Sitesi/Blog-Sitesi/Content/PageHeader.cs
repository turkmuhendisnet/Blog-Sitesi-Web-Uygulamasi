using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_Sitesi.Content
{
    public static class PageHeader
    {
        public static MvcHtmlString Baslik (this HtmlHelper helper, string Class="", string HeadStyle="", string Head = "")
        {
            string html = string.Format("<div class= '{0}'><h2 style='{1}'>{2}</h2></div> ",Class,HeadStyle,Head);
            return MvcHtmlString.Create(html);
        }
    }
}