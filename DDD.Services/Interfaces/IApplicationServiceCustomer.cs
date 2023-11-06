namespace DDD.Application.Interfaces
{
    public interface IApplicationServiceCustomer
    {
        Task AddAsync(Dtos.Requests.CustomerDto customerDto);
        Task UpdateAsync(Dtos.Requests.CustomerDto customerDto);
        Task RemoveAsync(Dtos.Requests.CustomerDto customerDto);
        Task<IEnumerable<Dtos.Responses.CustomerDto>> GetAllAsync();
        Task<Dtos.Responses.CustomerDto> FindByIdAsync(int id);
    }
}
