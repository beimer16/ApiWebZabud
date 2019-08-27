using ApiWebZabud.Core.Repositories.ClientRepository;
using ApiWebZabud.Core.Repositories.ProductRepository;
using ApiWebZabud.Core.Repositories.ShoppingRepository;
using ApiWebZabud.Core.Services.ClientService;
using ApiWebZabud.Core.Services.ProductService;
using ApiWebZabud.Core.Services.ShoppingService;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace ApiWebZabud.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IClientRepository, ClientRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IShoppingRepository, ShoppingRepository>();

            container.RegisterType<IClientService, ClientService>();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IShoppingService, ShoppingService>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}