using BM.Data.Common.Interfaces;
using NetCoders.MicroErpDD.Domain.Interfaces.Repository;
using NetCoders.MicroErpDDD.Infra.Repositories;
using NetCoders.MicroErpDDD.Infra.Repositories.Base;
using SimpleInjector;

namespace NetCoders.MicroErpDDD.Infra.IoC.Conteiners
{
    public static class RepositoryContainer
    {
        public static void Initialize(Container container, Lifestyle lifestyle)
        {
            container.Register<IProdutoRepository, ProdutoRepository>(lifestyle);
            container.Register<ICompraRepository, CompraRepository>(lifestyle);
            container.Register<ICompraItemRepository, CompraItemRepository>(lifestyle);
            container.Register<IFornecedorRepository, FornecedorRepository>(lifestyle);
        }
    }
}
