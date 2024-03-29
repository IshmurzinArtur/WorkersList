﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WorkersList
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Models.WorkersContext workersContext = new Models.WorkersContext();
            workersContext.Database.Initialize(false);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
