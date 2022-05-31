using DDD.Application.Dtos;

namespace DDD.Application.Interfaces
{
    public interface IApplicationCliente
    {
        void Add(ClienteDto clienteDto);
        void Update(ClienteDto clienteDto);
        void Remove(ClienteDto clienteDto);
        IEnumerable<ClienteDto> GetAll();
        ClienteDto GetById(int id);
    }
}
