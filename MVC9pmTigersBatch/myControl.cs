using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC9pmTigersBatch
{
    public static class myControl
    {
        public static IHtmlString MyLabel(string content)
        {
            string htmlstring = String.Format("<label>{0}</label>", content);
            return new HtmlString(htmlstring);
        }
        public static IHtmlString createUrControl(this HtmlHelper helper, string type)
        {
            string htmlstring = "<input type=" + type + ">";
            return new HtmlString(htmlstring);
        }
        public static IHtmlString createUrControl(this HtmlHelper helper, string type, string style, string eventfunction)
        {
            string htmlstring = "<input type=" + type + " style="+style+" onclick="+eventfunction+">";
            return new HtmlString(htmlstring);
        }
        public static IHtmlString createUrControl(this HtmlHelper helper, string type, string style,string eventName, string eventfunction)
        {
            string htmlstring = "<input type=" + type + " style=" + style+ " "+eventName+"="+eventfunction + ">";
            return new HtmlString(htmlstring);
        }

    }
}