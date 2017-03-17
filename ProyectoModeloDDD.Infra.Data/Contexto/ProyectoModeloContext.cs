using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoModeloDDD.Domain.Entities;

namespace ProyectoModeloDDD.Infra.Data.Contexto
{
    public class ProyectoModeloContext : DbContext
    {
        public ProyectoModeloContext()
            : base("ProyectoModeloDDD")
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }

    }
}
