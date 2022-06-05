using Autofac;
using DDD.Application;
using DDD.Application.Interfaces;
using DDD.Domain.Interfaces.Repositories;
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

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            
            #endregion
        }

    }
}
