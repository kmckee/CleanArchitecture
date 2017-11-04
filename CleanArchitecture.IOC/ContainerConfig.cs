using System;
using System.Web.Mvc;
using Ninject;
using Ninject.Web.Mvc;

namespace CleanArchitecture.IOC
{
    public static class ContainerConfig
    {
        public static void RegisterDependencies(Action<IDependencyResolver> setResolver)
        {
            setResolver(new NinjectDependencyResolver(new StandardKernel(
                new CommonModule()
            )));
        }
    }
}