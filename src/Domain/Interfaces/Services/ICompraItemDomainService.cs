using NetCoders.MicroErpDD.Domain.Entities;

namespace NetCoders.MicroErpDD.Domain.Interfaces.Services
{
    public interface ICompraItemDomainService
    {
        void ValidarProdutoExistente(CompraItem compraItem);
    }
}
