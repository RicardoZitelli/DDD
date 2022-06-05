using AutoMapper;
using DDD.Application.Dtos;
using DDD.Dominio.Entities;

namespace DDD.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Produto, ProdutoDto>().ReverseMap();            
        }

    }
}
