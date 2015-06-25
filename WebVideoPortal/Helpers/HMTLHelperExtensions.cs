using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace WebVideoPortal.Web.Helpers
{
    public static class HMTLHelperExtensions
    {
        public static string IsSelected(this HtmlHelper html, string controller = null, string action = null)
        {
            string cssClass = "active";
            string currentAction = (string)html.ViewContext.RouteData.Values["action"];
            string currentController = (string)html.ViewContext.RouteData.Values["controller"];

            if (String.IsNullOrEmpty(controller))
                controller = currentController;

            if (String.IsNullOrEmpty(action))
                action = currentAction;

            return controller == currentController && action == currentAction ?
                cssClass : String.Empty;
        }

        public static MvcHtmlString CustomEnumDropDownListFor<TModel, TEnum>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TEnum>> expression, object htmlAttributes)
        {
            var isNullable = false;

            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            var type = typeof(TEnum);
            if(Nullable.GetUnderlyingType(type) != null)
            {
                isNullable = true;
                type = Nullable.GetUnderlyingType(type);
            }
            var values = Enum.GetValues(type).Cast<object>();

            var items =
                values.Select(
                   value =>
                   new SelectListItem
                   {
                       Text = GetEnumDescription(value),
                       Value = value.ToString(),
                       Selected = value.Equals(metadata.Model)
                   }).ToList();

            if(isNullable)
            {
                items.Insert(0, new SelectListItem { Text = "" });
            }

            var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            return htmlHelper.DropDownListFor(expression, items, attributes);
        }

        public static string GetEnumDescription<TEnum>(TEnum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }

        public static string PageClass(this HtmlHelper html)
        {
            string currentAction = (string)html.ViewContext.RouteData.Values["action"];
            return currentAction;
        }

	}
}
