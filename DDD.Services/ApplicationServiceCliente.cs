using AutoMapper;
using DDD.Application.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Domain.Entities;
using DDD.Application.Dtos.Responses;

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

        public async Task AddAsync(Dtos.Requests.ClienteDto clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            cliente.DataCadastro = DateTime.Now;
            await _serviceCliente.AddAsync(cliente);
        }

        public async Task<IEnumerable<ClienteDto>> GetAllAsync()
        {
            var clientes = await _serviceCliente.GetAllAsync();
            return _mapper.Map<IEnumerable<ClienteDto>>(clientes);

        }

        public async Task<ClienteDto> FindByIdAsync(int id)
        {   
            var cliente = await _serviceCliente.FindByIdAsync(id);
            return _mapper.Map<ClienteDto>(cliente);
        }

        public async Task RemoveAsync(Dtos.Requests.ClienteDto clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            await _serviceCliente.RemoveAsync(cliente);
        }

        public async Task UpdateAsync(Dtos.Requests.ClienteDto clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            await _serviceCliente.UpdateAsync(cliente);
        }
    }
}
