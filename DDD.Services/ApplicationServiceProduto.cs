using AutoMapper;
using DDD.Application.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Domain.Entities;

namespace DDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto _serviceProduto;
        private readonly IMapper _mapper;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapper mapper)
        {
            _serviceProduto = serviceProduto;
            _mapper = mapper;
        }

        public void Add(Dtos.Requests.ProdutoDto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            produto.IsDisponivel = true;
            _serviceProduto.Add(produto);
        }

        public IEnumerable<Dtos.Responses.ProdutoDto> GetAll()
        {
            var produtos = _serviceProduto.GetAll();
            return _mapper.Map<IEnumerable<Dtos.Responses.ProdutoDto>>(produtos);
        }

        public Dtos.Responses.ProdutoDto FindById(int id)
        {
            var produto = _serviceProduto.FindById(id);
            return _mapper.Map<Dtos.Responses.ProdutoDto>(produto);
        }

        public void Remove(Dtos.Requests.ProdutoDto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            _serviceProduto.Remove(produto);
        }

        public void Update(Dtos.Requests.ProdutoDto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            _serviceProduto.Update(produto);
        }
    }
}
