using DDD.Domain.Repositories.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Domain.Entities;

namespace DDD.Domain.Services
{
    public class ServiceProduct(IRepositoryProduct repositoryProduto) : ServiceBase<Product>(repositoryProduto), IServiceProduct
    {
    }
}
