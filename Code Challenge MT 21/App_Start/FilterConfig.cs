﻿using System.Web;
using System.Web.Mvc;

namespace Code_Challenge_MT_21
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
