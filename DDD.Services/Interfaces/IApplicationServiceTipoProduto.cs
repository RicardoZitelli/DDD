namespace DDD.Application.Interfaces
{
    public interface IApplicationServiceTipoProduto
    {
        void Add(Dtos.Requests.TipoProdutoDto produtoDto);
        void Update(Dtos.Requests.TipoProdutoDto produtoDto);
        void Remove(Dtos.Requests.TipoProdutoDto produtoDto);
        IEnumerable<Dtos.Responses.TipoProdutoDto> GetAll();
        Dtos.Responses.TipoProdutoDto FindById(int id);
    }
}
