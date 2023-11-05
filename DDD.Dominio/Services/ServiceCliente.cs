using DDD.Domain.Repositories.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Domain.Entities;

namespace DDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {        
        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            
        }
    }
}
