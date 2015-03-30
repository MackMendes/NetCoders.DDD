using NetCoders.MicroErpDD.Domain.Entities;
using NetCoders.MicroErpDD.Domain.Interfaces.Repository;
using NetCoders.MicroErpDD.Domain.Interfaces.Services;
using NetCoders.MicroErpDDD.Application.Interfaces;

namespace NetCoders.MicroErpDDD.Application.Services
{
    public sealed class CompraApplicationService : ICompraApplicationService
    {
        /// <summary>
        /// Aqui na Application, não pode ter validações...
        /// </summary>
        private readonly ICompraRepository _compraRepository;
        private readonly ICompraItemRepository _compraItemRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICompraItemDomainService _compraItemDomainService;

        public CompraApplicationService(ICompraRepository compraRepository, ICompraItemRepository compraItemRepository,
            IProdutoRepository produtoRepository, ICompraItemDomainService compraItemDomainService)
        {
            this._compraRepository = compraRepository;
            this._compraItemRepository = compraItemRepository;
            this._produtoRepository = produtoRepository;
            this._compraItemDomainService = compraItemDomainService;
        }

        public void Salvar(Compra compra)
        {

            foreach (var compraItem in compra.Itens)
                _compraItemDomainService.ValidarProdutoExistente(compraItem);



            // Para usar BeginTransation teria que implementar uma padrão Unit of Work e deixar disponível aki
            // A Application, que deve gerenciar a Transation
            try
            {
                // BeginTransation
                _compraRepository.Add(compra);
                foreach (var compraItem in compra.Itens)
                    _compraItemRepository.Add(compraItem);
                // Commit
            }
            catch 
            {
                // RollBack
                throw;
            }
            
        }
    }
}
