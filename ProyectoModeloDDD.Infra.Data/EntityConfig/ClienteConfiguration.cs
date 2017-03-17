using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoModeloDDD.Domain.Entities;

namespace ProyectoModeloDDD.Infra.Data.EntityConfig
{
    public class ClienteConfiguration: EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nombre)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Apellido)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();


        }
    }
}
