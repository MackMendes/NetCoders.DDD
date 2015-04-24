using NetCoders.MicroErpDDD.Application.Interfaces;
using NetCoders.MicroErpDDD.Application.Services;
using SimpleInjector;

namespace NetCoders.MicroErpDDD.Infra.IoC.Conteiners
{
    public static class ApplicationServiceContainer
    {
        public static void Initialize(Container container, Lifestyle lifestyle)
        {
            container.Register<ICompraApplicationService, CompraApplicationService>(lifestyle);
        }
    }
}
