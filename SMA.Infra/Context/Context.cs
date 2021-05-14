using SMA.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Study.Infra
{
    public class Context : DbContext
    {
        public Context() : base("name=DefaultConnection")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public IDbSet<Usuario> Usuarios { get; set; }
        public IDbSet<Cargo> Cargos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));
            modelBuilder.Configurations.AddFromAssembly(typeof(Context).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}