using System.Web;
using System.Web.Mvc;

namespace _1911066291_NguyenHoangPhuoc_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
