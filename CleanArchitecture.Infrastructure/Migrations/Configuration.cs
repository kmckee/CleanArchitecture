using CleanArchitecture.Core.Models;

namespace CleanArchitecture.Infrastructure.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context context)
        {
            context.Widgets.AddOrUpdate(new Widget() { WidgetId = 1, Name = "Kyle" });
            context.SaveChanges();
        }
    }
}
