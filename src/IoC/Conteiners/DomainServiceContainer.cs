using NetCoders.MicroErpDD.Domain.Interfaces.Services;
using NetCoders.MicroErpDD.Domain.Services;
using SimpleInjector;

namespace NetCoders.MicroErpDDD.Infra.IoC.Conteiners
{
    public static class DomainServiceContainer
    {
        public static void Initialize(Container container, Lifestyle lifestyle)
        {
            container.Register<ICompraItemDomainService, CompraItemDomainService>(lifestyle);
        }
    }
}
