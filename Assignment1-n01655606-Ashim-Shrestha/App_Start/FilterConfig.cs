using System.Web;
using System.Web.Mvc;

namespace Assignment1_n01655606_Ashim_Shrestha
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
