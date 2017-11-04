using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using CleanArchitecture.IOC;
using Ninject;
using Ninject.Web.Common.WebHost;
using Ninject.Web.Mvc;

namespace CleanArchitecture.UI
{
    public class MvcApplication : System.Web.HttpApplication //: NinjectHttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(new ApplicationKernel()));
        }
    }
}
