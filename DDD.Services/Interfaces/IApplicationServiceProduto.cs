namespace DDD.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(Dtos.Requests.ProdutoDto produtoDto);
        void Update(Dtos.Requests.ProdutoDto produtoDto);
        void Remove(Dtos.Requests.ProdutoDto produtoDto);
        IEnumerable<Dtos.Responses.ProdutoDto> GetAll();
        Dtos.Responses.ProdutoDto FindById(int id);
    }
}
