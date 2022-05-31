using DDD.Domain.Interfaces.Repositories;
using DDD.Domain.Services.Interfaces;
using DDD.Dominio.Entities;

namespace DDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;
        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}
