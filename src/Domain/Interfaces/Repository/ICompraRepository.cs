using BM.Data.Common.Interfaces;
using NetCoders.MicroErpDD.Domain.Entities;
using System.Collections.Generic;

namespace NetCoders.MicroErpDD.Domain.Interfaces.Repository
{
    public interface ICompraRepository : IRepositoryBase<Compra>
    {
        IEnumerable<Compra> ConsultarComFornecedor();
    }
}
