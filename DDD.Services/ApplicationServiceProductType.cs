using AutoMapper;
using DDD.Application.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Domain.Entities;
using DDD.Application.Dtos.Responses;

namespace DDD.Application
{
    public class ApplicationServiceProductType : IApplicationServiceProductType
    {
        private readonly IServiceProductType _serviceProductType;
        private readonly IMapper _mapper;

        public ApplicationServiceProductType(IServiceProductType serviceProductType, IMapper mapper)
        {
            _serviceProductType = serviceProductType;
            _mapper = mapper;
        }

        public async Task AddAsync(Dtos.Requests.ProductTypeDto productTypeDto)
        {
            var productType = _mapper.Map<ProductType>(productTypeDto);
            productType.Ativo = true;
            productType.DataCriacao = DateTime.Now;
            productType.DataAlteracao = null;
            await _serviceProductType.AddAsync(productType);
        }

        public async Task<IEnumerable<Dtos.Responses.ProductTypeDto>> GetAllAsync()
        {
            var ProductTypes = await _serviceProductType.GetAllAsync();
            return _mapper.Map<IEnumerable<Dtos.Responses.ProductTypeDto>>(ProductTypes);
        }

        public async Task<ProductTypeDto> FindByIdAsync(int id)
        {
            var productType = await _serviceProductType.FindByIdAsync(id);
            return _mapper.Map<Dtos.Responses.ProductTypeDto>(productType);
        }

        public async Task RemoveAsync(Dtos.Requests.ProductTypeDto productTypeDto)
        {
            var productType = _mapper.Map<ProductType>(productTypeDto);
            await _serviceProductType.RemoveAsync(productType);
        }

        public async Task UpdateAsync(Dtos.Requests.ProductTypeDto productTypeDto)
        {
            var productType = _mapper.Map<ProductType>(productTypeDto);
            await _serviceProductType.UpdateAsync(productType);
        }
    }
}
