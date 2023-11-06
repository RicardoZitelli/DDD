using DDD.Domain.Repositories.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Domain.Entities;

namespace DDD.Domain.Services
{
    public class ServiceCustomer : ServiceBase<Customer>, IServiceCustomer
    {        
        public ServiceCustomer(IRepositoryCustomer repositoryCliente) : base(repositoryCliente)
        {
            
        }
    }
}
