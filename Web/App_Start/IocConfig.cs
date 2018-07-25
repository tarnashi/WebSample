using Core;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using System.Web.Mvc;

namespace Web
{
    public class IocConfig
    {
        public static void ConfigureContainer()
        {
            NinjectModule registerModule = new ServiceModule();
            var kernel = new StandardKernel(registerModule);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}