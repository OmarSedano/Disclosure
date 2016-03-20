using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Disclosure.Application.Contracts.ServiceContracts;
using Disclosure.Application.Impl.Services;
using Disclosure.Infrastructure.Data.Contracts;
using Disclosure.Infrastructure.Data.Impl.Repositories;

namespace Disclosure.App_Start
{
    public static class AutofacConfig
    {
        public static void BuildContainerBuilderAndSetDependencyResolver()
        {

            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            RegisterApplicationServices(builder);
            RegisterInfrastructureData(builder);

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static void RegisterInfrastructureData(ContainerBuilder builder)
        {
            builder.RegisterType<NewsRepository>().As<INewsRepository>();
        }

        private static void RegisterApplicationServices(ContainerBuilder builder)
        {
            builder.RegisterType<NewsService>().As<INewsService>();
        }
    }
}