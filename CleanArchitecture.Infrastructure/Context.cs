using CleanArchitecture.Core.Models;
using System.Data.Entity;

namespace CleanArchitecture.Infrastructure
{
    public class Context : DbContext
    {
        // Your context has been configured to use a 'Context' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CleanArchitecture.Infrastructure.Context' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Context' 
        // connection string in the application configuration file.
        public Context()
            : base("name=Context")
        { }

        public virtual DbSet<Widget> Widgets { get; set; }
        public virtual DbSet<Thing> Things { get; set; }
        public virtual DbSet<Contraption> Contraptions { get; set; }
        public virtual DbSet<Gizmo> Gizmos { get; set; }
    }
}