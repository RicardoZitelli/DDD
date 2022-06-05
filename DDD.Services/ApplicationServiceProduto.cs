using AutoMapper;
using DDD.Application.Dtos;
using DDD.Application.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Dominio.Entities;

namespace DDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        private readonly IMapper mapper;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapper mapper)
        {
            this.serviceProduto = serviceProduto;
            this.mapper = mapper;
        }

        public void Add(ProdutoDto produtoDto)
        {
            var produto = this.mapper.Map<Produto>(produtoDto);
            this.serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = this.serviceProduto.GetAll();
            return this.mapper.Map<IEnumerable<ProdutoDto>>(produtos);
        }

        public ProdutoDto FindById(int id)
        {
            var produto = this.serviceProduto.FindById(id);
            return this.mapper.Map<ProdutoDto>(produto);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = this.mapper.Map<Produto>(produtoDto);
            this.serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = this.mapper.Map<Produto>(produtoDto);
            this.serviceProduto.Update(produto);
        }
    }
}
