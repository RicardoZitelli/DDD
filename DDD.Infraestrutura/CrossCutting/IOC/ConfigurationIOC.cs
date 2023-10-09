using Autofac;
using DDD.Application;
using DDD.Application.Interfaces;
using DDD.Domain.Repositories.Interfaces;
using DDD.Domain.Services;
using DDD.Domain.Services.Interfaces;
using DDD.Infrastructure.Data.Repositories;

namespace DDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            ConfigurarAplicacoes(builder);

            ConfigurarServiços(builder);

            ConfigurarRepositorios(builder);

            #endregion
        }

        private static void ConfigurarAplicacoes(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ApplicationServiceTipoProduto>().As<IApplicationServiceTipoProduto>();
        }

        private static void ConfigurarServiços(ContainerBuilder builder)
        {
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<ServiceTipoProduto>().As<IServiceTipoProduto>();
        }

        private static void ConfigurarRepositorios(ContainerBuilder builder)
        {
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<RepositoryTipoProduto>().As<IRepositoryTipoProduto>();
        }
    }
}
