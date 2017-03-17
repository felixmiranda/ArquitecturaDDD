using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoModeloDDD.Domain.Entities;
using ProyectoModeloDDD.Domain.Interfaces;

namespace ProyectoModeloDDD.Infra.Data.Repositories
{
    public class ProductoRepository : RepositoryBase<Producto>, IProductoRepository
    {
        public IEnumerable<Producto> BuscarPorNombre(string Nombre)
        {
            return Db.Producto.Where(p => p.Nombre == Nombre);
        }
    }
}
