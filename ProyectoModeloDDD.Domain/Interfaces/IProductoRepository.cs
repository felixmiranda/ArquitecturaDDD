using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoModeloDDD.Domain.Entities;

namespace ProyectoModeloDDD.Domain.Interfaces
{
    public interface IProductoRepository : IRepositoryBase<Producto>
    {
        IEnumerable<Producto> BuscarPorNombre(string Nombre);

    }
}
