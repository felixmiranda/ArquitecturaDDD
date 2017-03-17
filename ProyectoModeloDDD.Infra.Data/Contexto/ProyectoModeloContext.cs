using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using ProyectoModeloDDD.Domain.Entities;
using ProyectoModeloDDD.Infra.Data.EntityConfig;

namespace ProyectoModeloDDD.Infra.Data.Contexto
{
    public class ProyectoModeloContext : DbContext
    {
        public ProyectoModeloContext()
            : base("ProyectoModeloDDD")
        {
            
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Producto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Elimina la pluralizacion de las tablas (entityFramework)
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p=>p.Name == p.ReflectedType.Name + "Id")
                .Configure(p=> p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p=> p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p=> p.HasMaxLength(100));

            
            // Configuracion de las clases tipo entidad
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProductoConfiguration());

        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("FechaRegistro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("FechaRegistro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("RechaRegistro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}
