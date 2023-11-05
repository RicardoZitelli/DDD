using DDD.Domain.Repositories.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Domain.Entities;

namespace DDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {        
        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            
        }
    }
}
