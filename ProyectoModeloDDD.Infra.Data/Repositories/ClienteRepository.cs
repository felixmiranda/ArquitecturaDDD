using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoModeloDDD.Domain.Entities;
using ProyectoModeloDDD.Domain.Interfaces;

namespace ProyectoModeloDDD.Infra.Data.Repositories
{
    public class ClienteRepository: RepositoryBase<Cliente>, IClienteRepository
    {

    }
}
