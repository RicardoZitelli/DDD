using AutoMapper;
using DDD.Application.Dtos;
using DDD.Application.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Dominio.Entities;

namespace DDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente serviceCliente;
        private readonly IMapper mapper;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapper mapper)
        {
            this.serviceCliente = serviceCliente;            
            this.mapper = mapper;            
        }

        public void Add(ClienteDto clienteDto)
        {
            var cliente = this.mapper.Map<Cliente>(clienteDto);
            this.serviceCliente.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = this.serviceCliente.GetAll();
            return this.mapper.Map<IEnumerable<ClienteDto>>(clientes);

        }

        public ClienteDto GetById(int id)
        {   
            var cliente = this.serviceCliente.FindById(id);
            return this.mapper.Map<ClienteDto>(cliente);
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = this.mapper.Map<Cliente>(clienteDto);
            serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = this.mapper.Map<Cliente>(clienteDto);
            serviceCliente.Update(cliente);
        }
    }
}
