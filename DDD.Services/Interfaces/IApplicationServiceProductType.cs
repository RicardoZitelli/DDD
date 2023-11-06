namespace DDD.Application.Interfaces
{
    public interface IApplicationServiceProductType
    {
        Task AddAsync(Dtos.Requests.ProductTypeDto productTypeDto);
        Task UpdateAsync(Dtos.Requests.ProductTypeDto productTypeDto);
        Task RemoveAsync(Dtos.Requests.ProductTypeDto productTypeDto);
        Task<IEnumerable<Dtos.Responses.ProductTypeDto>> GetAllAsync();
        Task<Dtos.Responses.ProductTypeDto> FindByIdAsync(int id);
    }
}
