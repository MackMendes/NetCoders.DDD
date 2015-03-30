[assembly: WebActivator.PostApplicationStartMethod(typeof(NetCoders.MicroErpDDD.Infra.IoC.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace NetCoders.MicroErpDDD.Infra.IoC.App_Start
{
    using CommonServiceLocator.SimpleInjectorAdapter;
    using Microsoft.Practices.ServiceLocation;
    using NetCoders.MicroErpDDD.Infra.IoC.Conteiners;
    using SimpleInjector;
    using SimpleInjector.Integration.Web.Mvc;
    using System.Reflection;
    using System.Web.Mvc;

    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();

            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();
            // Essa express�o Lambda abaixo (() => new SimpleInjectorServiceLocatorAdapter(container)), esta fazendo uma "parse" do tipo 
            // SimpleInjectorServiceLocatorAdapter para o ServicerLocatorProvider, que o � esperado. Isso s� � poss�vel por causa da Interfaces que 
            // s�o comuns para as tudas classes, a interface IServiceLocator;
            ServiceLocator.SetLocatorProvider(() => new SimpleInjectorServiceLocatorAdapter(container));
            
            // Para pegar a inst�ncia do Objeto informado, s� fazer: var objProduto = ServiceLocator.Current.GetInstance<IProduto>();
             
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void InitializeContainer(Container container)
        {
            RepositoryContainer.Initialize(container, Lifestyle.Singleton);
        }
    }
}