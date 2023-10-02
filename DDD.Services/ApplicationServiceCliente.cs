using AutoMapper;
using DDD.Application.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Domain.Entities;
using DDD.Application.Dtos;

namespace DDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapper _mapper;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapper mapper)
        {
            _serviceCliente = serviceCliente;            
            _mapper = mapper;            
        }

        public void Add(Dtos.Requests.ClienteDto clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            cliente.DataCadastro = DateTime.Now;
            _serviceCliente.Add(cliente);
        }

        public IEnumerable<Dtos.Responses.ClienteDto> GetAll()
        {
            var clientes = _serviceCliente.GetAll();
            return _mapper.Map<IEnumerable<Dtos.Responses.ClienteDto>>(clientes);

        }

        public Dtos.Responses.ClienteDto FindById(int id)
        {   
            var cliente = _serviceCliente.FindById(id);
            return _mapper.Map<Dtos.Responses.ClienteDto>(cliente);
        }

        public void Remove(Dtos.Requests.ClienteDto clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            _serviceCliente.Remove(cliente);
        }

        public void Update(Dtos.Requests.ClienteDto clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            _serviceCliente.Update(cliente);
        }
    }
}
