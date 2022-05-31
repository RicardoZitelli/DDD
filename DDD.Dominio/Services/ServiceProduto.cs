using DDD.Domain.Interfaces.Repositories;
using DDD.Domain.Services.Interfaces;
using DDD.Dominio.Entities;

namespace DDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;
        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}
