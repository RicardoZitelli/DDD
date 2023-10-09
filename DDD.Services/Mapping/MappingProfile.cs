using AutoMapper;
using DDD.Application.Dtos;
using DDD.Domain.Entities;

namespace DDD.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, Dtos.Responses.ClienteDto>();
            CreateMap<Produto, Dtos.Responses.ProdutoDto>();
            CreateMap<TipoProduto,Dtos.Responses.TipoProdutoDto>();

            CreateMap<Dtos.Requests.ClienteDto,Cliente>();
            CreateMap<Dtos.Requests.ProdutoDto,Produto>();
            CreateMap<Dtos.Requests.TipoProdutoDto, TipoProduto>();
        }

    }
}
