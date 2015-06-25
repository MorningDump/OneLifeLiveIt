using System.Web;
using System.Web.Mvc;
using WebVideoPortal.Filters;

namespace WebVideoPortal
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new HandleExceptionAttribute());
        }
    }
}
