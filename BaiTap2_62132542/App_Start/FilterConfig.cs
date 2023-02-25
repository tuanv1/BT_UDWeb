using System.Web;
using System.Web.Mvc;

namespace BaiTap2_62132542
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
