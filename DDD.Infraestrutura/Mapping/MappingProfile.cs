using AutoMapper;
using DDD.Application.Dtos;
using DDD.Dominio.Entities;

namespace DDD.Infrastructure.Mapping
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Produto, ProdutoDto>().ReverseMap();            
        }

    }
}
