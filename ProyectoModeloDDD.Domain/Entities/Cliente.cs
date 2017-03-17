using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModeloDDD.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }


        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Activo && DateTime.Now.Year - cliente.FechaRegistro.Year >= 5;
        }

    }
}
