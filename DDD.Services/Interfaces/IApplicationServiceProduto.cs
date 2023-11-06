namespace DDD.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        Task AddAsync(Dtos.Requests.ProdutoDto produtoDto);
        Task UpdateAsync(Dtos.Requests.ProdutoDto produtoDto);
        Task RemoveAsync(Dtos.Requests.ProdutoDto produtoDto);
        Task<IEnumerable<Dtos.Responses.ProdutoDto>> GetAllAsync();
        Task<Dtos.Responses.ProdutoDto> FindByIdAsync(int id);
    }
}
