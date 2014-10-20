using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONETUG.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString GroupTitle<T>(this HtmlHelper<T> htmlHelper)
        {
            return new MvcHtmlString(GroupSettings.Instance.Title);
        }

        public static MvcHtmlString GroupName<T>(this HtmlHelper<T> htmlHelper)
        {
            return new MvcHtmlString(GroupSettings.Instance.Name);
        }

        public static MvcHtmlString GroupEmailAddress<T>(this HtmlHelper<T> htmlHelper)
        {
            return new MvcHtmlString(GroupSettings.Instance.EmailAddress);
        }

        public static MvcHtmlString MeetupGroupName<T>(this HtmlHelper<T> htmlHelper)
        {
            return new MvcHtmlString(GroupSettings.Instance.MeetupGroupName);
        }

        public static MvcHtmlString TwitterHandle<T>(this HtmlHelper<T> htmlHelper)
        {
            return new MvcHtmlString(GroupSettings.Instance.TwitterHandle);
        }

        public static MvcHtmlString TwitterWidgetId<T>(this HtmlHelper<T> htmlHelper)
        {
            return new MvcHtmlString(GroupSettings.Instance.TwitterWidgetId);
        }
    }
}