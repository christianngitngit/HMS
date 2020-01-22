using System.Web;
using System.Web.Mvc;

namespace HMS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //Global authorization
            //filters.Add(new AuthorizeAttribute());
        }
    }
}
