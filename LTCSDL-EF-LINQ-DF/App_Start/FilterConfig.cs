using System.Web;
using System.Web.Mvc;

namespace LTCSDL_EF_LINQ_DF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
