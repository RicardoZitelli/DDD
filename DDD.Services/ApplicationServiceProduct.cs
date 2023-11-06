using AutoMapper;
using DDD.Application.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Domain.Entities;

namespace DDD.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct _serviceProduct;
        private readonly IMapper _mapper;

        public ApplicationServiceProduct(IServiceProduct serviceProduct, IMapper mapper)
        {
            _serviceProduct = serviceProduct;
            _mapper = mapper;
        }

        public async Task AddAsync(Dtos.Requests.ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            product.IsDisponivel = true;
            await _serviceProduct.AddAsync(product);
        }

        public async Task<IEnumerable<Dtos.Responses.ProductDto>> GetAllAsync()
        {
            var products = await _serviceProduct.GetAllAsync();
            return _mapper.Map<IEnumerable<Dtos.Responses.ProductDto>>(products);
        }

        public async Task<Dtos.Responses.ProductDto> FindByIdAsync(int id)
        {
            var product = await _serviceProduct.FindByIdAsync(id);
            return _mapper.Map<Dtos.Responses.ProductDto>(product);
        }

        public async Task RemoveAsync(Dtos.Requests.ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _serviceProduct.RemoveAsync(product);
        }

        public async Task UpdateAsync(Dtos.Requests.ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _serviceProduct.UpdateAsync(product);
        }
    }
}
