using CleanArchitecture.Core.Contracts;
using CleanArchitecture.Infrastructure.Repositories;
using Ninject.Modules;

namespace CleanArchitecture.IOC
{
    public class CommonModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWidgetRepository>().To<WidgetRepository>();
        }
    }
}
