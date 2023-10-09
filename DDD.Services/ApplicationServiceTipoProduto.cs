using AutoMapper;
using DDD.Application.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Domain.Entities;

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

        public void Add(Dtos.Requests.TipoProdutoDto produtoDto)
        {
            var tipoProduto = _mapper.Map<TipoProduto>(produtoDto);
            tipoProduto.Ativo = true;
            _serviceTipoProduto.Add(tipoProduto);
        }

        public IEnumerable<Dtos.Responses.TipoProdutoDto> GetAll()
        {
            var tipoProdutos = _serviceTipoProduto.GetAll();
            return _mapper.Map<IEnumerable<Dtos.Responses.TipoProdutoDto>>(tipoProdutos);
        }

        public Dtos.Responses.TipoProdutoDto FindById(int id)
        {
            var produto = _serviceTipoProduto.FindById(id);
            return _mapper.Map<Dtos.Responses.TipoProdutoDto>(produto);
        }

        public void Remove(Dtos.Requests.TipoProdutoDto produtoDto)
        {
            var tipoProduto = _mapper.Map<TipoProduto>(produtoDto);
            _serviceTipoProduto.Remove(tipoProduto);
        }

        public void Update(Dtos.Requests.TipoProdutoDto produtoDto)
        {
            var tipoProduto = _mapper.Map<TipoProduto>(produtoDto);
            _serviceTipoProduto.Update(tipoProduto);
        }
    }
}
