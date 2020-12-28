using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelFirstApproach.Controls
{
    public static class MyControls
    {
        public static IHtmlString MyLabel(string content,string Color)
        {
            string htmlstring = String.Format("<label style='color:"+Color+"'>{0}</label>", content);
            return new HtmlString(htmlstring);
        }

        public static IHtmlString createUrControl(this HtmlHelper helper, string content)
        {
            string htmlstring = "<input type=" + content + ">";
            return new HtmlString(htmlstring);
        }

    }
}