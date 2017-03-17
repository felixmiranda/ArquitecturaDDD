using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ProyectoModeloDDD.Domain.Entities
{
    [Table("Cliente")]   
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }

        public virtual IEnumerable<Producto> Productos { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Activo && DateTime.Now.Year - cliente.FechaRegistro.Year >= 5;
        }

    }
}
