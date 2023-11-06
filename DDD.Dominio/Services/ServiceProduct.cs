using DDD.Domain.Repositories.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Domain.Entities;

namespace DDD.Domain.Services
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {        
        public ServiceProduct(IRepositoryProduct repositoryProduto) : base(repositoryProduto)
        {
            
        }
    }
}
