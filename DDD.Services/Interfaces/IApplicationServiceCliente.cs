namespace DDD.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        Task AddAsync(Dtos.Requests.ClienteDto clienteDto);
        Task UpdateAsync(Dtos.Requests.ClienteDto clienteDto);
        Task RemoveAsync(Dtos.Requests.ClienteDto clienteDto);
        Task<IEnumerable<Dtos.Responses.ClienteDto>> GetAllAsync();
        Task<Dtos.Responses.ClienteDto> FindByIdAsync(int id);
    }
}
