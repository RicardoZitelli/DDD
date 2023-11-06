namespace DDD.Application.Interfaces
{
    public interface IApplicationServiceProduct
    {
        Task AddAsync(Dtos.Requests.ProductDto productDto);
        Task UpdateAsync(Dtos.Requests.ProductDto productDto);
        Task RemoveAsync(Dtos.Requests.ProductDto productDto);
        Task<IEnumerable<Dtos.Responses.ProductDto>> GetAllAsync();
        Task<Dtos.Responses.ProductDto> FindByIdAsync(int id);
    }
}
