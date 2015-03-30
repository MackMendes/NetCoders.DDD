using BM.Data.Common.Interfaces;
using NetCoders.MicroErpDD.Domain.Entities;

namespace NetCoders.MicroErpDD.Domain.Interfaces.Repository
{
    /// <summary>
    /// A interface do IRepositoryBase, se fosse criada na mão, teria que ser criada na camada de NetCoders.MicroErpDD.Domain.Interfaces.Repository 
    /// (Aki mesmo nessa pasta)
    /// </summary>
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {

    }
}
