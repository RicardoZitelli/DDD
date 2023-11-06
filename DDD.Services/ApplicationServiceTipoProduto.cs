using AutoMapper;
using DDD.Application.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Domain.Entities;
using DDD.Application.Dtos.Responses;

namespace DDD.Application
{
    public class ApplicationServiceTipoProduto : IApplicationServiceTipoProduto
    {
        private readonly IServiceTipoProduto _serviceTipoProduto;
        private readonly IMapper _mapper;

        public ApplicationServiceTipoProduto(IServiceTipoProduto serviceTipoProduto, IMapper mapper)
        {
            _serviceTipoProduto = serviceTipoProduto;
            _mapper = mapper;
        }

        public async Task AddAsync(Dtos.Requests.TipoProdutoDto produtoDto)
        {
            var tipoProduto = _mapper.Map<TipoProduto>(produtoDto);
            tipoProduto.Ativo = true;
            await _serviceTipoProduto.AddAsync(tipoProduto);
        }

        public async Task<IEnumerable<Dtos.Responses.TipoProdutoDto>> GetAllAsync()
        {
            var tipoProdutos = await _serviceTipoProduto.GetAllAsync();
            return _mapper.Map<IEnumerable<Dtos.Responses.TipoProdutoDto>>(tipoProdutos);
        }

        public async Task<TipoProdutoDto> FindByIdAsync(int id)
        {
            var produto = await _serviceTipoProduto.FindByIdAsync(id);
            return _mapper.Map<Dtos.Responses.TipoProdutoDto>(produto);
        }

        public async Task RemoveAsync(Dtos.Requests.TipoProdutoDto produtoDto)
        {
            var tipoProduto = _mapper.Map<TipoProduto>(produtoDto);
            await _serviceTipoProduto.RemoveAsync(tipoProduto);
        }

        public async Task UpdateAsync(Dtos.Requests.TipoProdutoDto produtoDto)
        {
            var tipoProduto = _mapper.Map<TipoProduto>(produtoDto);
            await _serviceTipoProduto.UpdateAsync(tipoProduto);
        }
    }
}
