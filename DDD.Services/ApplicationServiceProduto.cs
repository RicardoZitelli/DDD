using AutoMapper;
using DDD.Application.Dtos;
using DDD.Application.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Dominio.Entities;

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

        public void Add(ProdutoDto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            produto.IsDisponivel = true;
            _serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = _serviceProduto.GetAll();
            return _mapper.Map<IEnumerable<ProdutoDto>>(produtos);
        }

        public ProdutoDto FindById(int id)
        {
            var produto = _serviceProduto.FindById(id);
            return _mapper.Map<ProdutoDto>(produto);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            _serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            _serviceProduto.Update(produto);
        }
    }
}
