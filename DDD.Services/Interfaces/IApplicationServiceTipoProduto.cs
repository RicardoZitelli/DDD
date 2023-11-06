namespace DDD.Application.Interfaces
{
    public interface IApplicationServiceTipoProduto
    {
        Task AddAsync(Dtos.Requests.TipoProdutoDto produtoDto);
        Task UpdateAsync(Dtos.Requests.TipoProdutoDto produtoDto);
        Task RemoveAsync(Dtos.Requests.TipoProdutoDto produtoDto);
        Task<IEnumerable<Dtos.Responses.TipoProdutoDto>> GetAllAsync();
        Task<Dtos.Responses.TipoProdutoDto> FindByIdAsync(int id);
    }
}
