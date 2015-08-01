using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day7HtmlHelpers.Helpers
{
    public static class ImageHelper
    {
        public static MvcHtmlString Image(this HtmlHelper helper, string url)
        {
            TagBuilder tb = new TagBuilder("img");
            tb.MergeAttribute("src", url);
            return MvcHtmlString.Create(tb.ToString(TagRenderMode.SelfClosing));
        }
    }

    public static class MvcHtmlString ShowPrice<TModel, (TProperty>(this HtmlHelper<TModel> helper, Expression)<Func<tModel, TProperty>> expression)
    {
        var name = ExpressionHelper.GetExpressionText(expression, helper.ViewData);

        var text = string.Forman("{0} is {1:c}", name metaData.Model);

        return MvcHtmlString.Create(text);
    }
}