using AutoMapper;
using DDD.Application.Dtos;
using DDD.Domain.Entities;

namespace DDD.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, Dtos.Responses.CustomerDto>();
            CreateMap<Product, Dtos.Responses.ProductDto>();
            CreateMap<ProductType,Dtos.Responses.ProductTypeDto>();

            CreateMap<Dtos.Requests.CustomerDto,Customer>();
            CreateMap<Dtos.Requests.ProductDto,Product>();
            CreateMap<Dtos.Requests.ProductTypeDto, ProductType>();
        }

    }
}
