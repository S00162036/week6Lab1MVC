﻿using System.Web;
using System.Web.Mvc;

namespace S00162036Rad2017Mvc1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
