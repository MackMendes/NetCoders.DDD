using NetCoders.MicroErpDD.Domain.Entities;
using NetCoders.MicroErpDD.Domain.Exceptions;
using NetCoders.MicroErpDD.Domain.Interfaces.Repository;
using NetCoders.MicroErpDD.Domain.Interfaces.Services;

namespace NetCoders.MicroErpDD.Domain.Services
{
    public sealed class CompraItemDomainService : ICompraItemDomainService
    {
        private readonly IProdutoRepository _produtoRepository;

        public CompraItemDomainService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void ValidarProdutoExistente(CompraItem compraItem)
        {
            if (_produtoRepository.Get(compraItem.Produto.IdProduto) == null)
                throw new CompraException(string.Format("O Produto {0} não existe!", compraItem.Produto.IdProduto), compraItem.Compra);
        }
    }
}
