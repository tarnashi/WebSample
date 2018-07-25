using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            IocConfig.ConfigureContainer();
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        }
    }
}
