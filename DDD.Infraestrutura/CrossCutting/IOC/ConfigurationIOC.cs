using Autofac;
using DDD.Application;
using DDD.Application.Interfaces;
using DDD.Domain.Repositories.Interfaces;
using DDD.Domain.Services;
using DDD.Domain.Services.Interfaces;
using DDD.Infrastructure.Data.Repositories;
using DDD.Infrastructure.ExternalAPIs.Correios;

namespace DDD.Infrastructure.CrossCutting.IOC
{
    public static class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            ConfigureApplications(builder);

            ConfigureServices(builder);

            ConfigureRepositories(builder);

            ConfigurationExternalServices(builder);

            #endregion
        }
                private static void ConfigureApplications(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationServiceCustomer>().As<IApplicationServiceCustomer>();
            builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();
            builder.RegisterType<ApplicationServiceProductType>().As<IApplicationServiceProductType>();
            builder.RegisterType<ApplicationServiceCorreiosApi>().As<IApplicationServiceCorreiosApi>();
        }

        private static void ConfigureServices(ContainerBuilder builder)
        {
            builder.RegisterType<ServiceCustomer>().As<IServiceCustomer>();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<ServiceProductType>().As<IServiceProductType>();

        }

        private static void ConfigureRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<RepositoryCustomer>().As<IRepositoryCustomer>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.RegisterType<RepositoryProductType>().As<IRepositoryProductType>();
        }

        private static void ConfigurationExternalServices(ContainerBuilder builder)
        {
            builder.RegisterType<CorreiosApi>().As<IServiceCorreiosApi>();
        }
    }
}
