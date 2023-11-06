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

        public async Task AddAsync(Dtos.Requests.ProdutoDto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            produto.IsDisponivel = true;
            await _serviceProduto.AddAsync(produto);
        }

        public async Task<IEnumerable<Dtos.Responses.ProdutoDto>> GetAllAsync()
        {
            var produtos = await _serviceProduto.GetAllAsync();
            return _mapper.Map<IEnumerable<Dtos.Responses.ProdutoDto>>(produtos);
        }

        public async Task<Dtos.Responses.ProdutoDto> FindByIdAsync(int id)
        {
            var produto = await _serviceProduto.FindByIdAsync(id);
            return _mapper.Map<Dtos.Responses.ProdutoDto>(produto);
        }

        public async Task RemoveAsync(Dtos.Requests.ProdutoDto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            await _serviceProduto.RemoveAsync(produto);
        }

        public async Task UpdateAsync(Dtos.Requests.ProdutoDto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            await _serviceProduto.UpdateAsync(produto);
        }
    }
}
