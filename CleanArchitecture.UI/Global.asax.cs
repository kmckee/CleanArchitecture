using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject;
using Ninject.Web.Common.WebHost;

namespace CleanArchitecture.UI
{
    public class MvcApplication : System.Web.HttpApplication // : NinjectHttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //protected override IKernel CreateKernel()
        //{
        //    var kernel = new StandardKernel();
        //    kernel.Load("~/bin");
        //    return kernel;
        //}
    }
}
