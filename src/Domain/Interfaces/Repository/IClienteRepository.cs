using BM.Data.Common.Interfaces;
using NetCoders.MicroErpDD.Domain.Entities;

namespace NetCoders.MicroErpDD.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IRepositoryBase<Cliente>
    {
        Cliente GetByCpf(string cpf);
    }
}
