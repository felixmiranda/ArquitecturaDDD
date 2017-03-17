using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModeloDDD.Domain.Entities
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public decimal Valor { get; set; }
        public bool Disponible { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

      
    }
}
