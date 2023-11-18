using AutoMapper;
using DDD.Application.Interfaces;
using DDD.Domain.Services.Interfaces;
using DDD.Domain.Entities;
using DDD.Application.Dtos.Responses;

namespace DDD.Application
{
    public class ApplicationServiceCustomer(IServiceCustomer serviceCustomer, IMapper mapper) : IApplicationServiceCustomer
    {
        private readonly IServiceCustomer _serviceCustomer = serviceCustomer;
        private readonly IMapper _mapper = mapper;

        public async Task AddAsync(Dtos.Requests.CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            customer.DataCadastro = DateTime.Now;
            await _serviceCustomer.AddAsync(customer);
        }

        public async Task<IEnumerable<CustomerDto>> GetAllAsync()
        {
            var customers = await _serviceCustomer.GetAllAsync();
            return _mapper.Map<IEnumerable<CustomerDto>>(customers);

        }

        public async Task<CustomerDto> FindByIdAsync(int id)
        {   
            var customer = await _serviceCustomer.FindByIdAsync(id);
            return _mapper.Map<CustomerDto>(customer);
        }

        public async Task RemoveAsync(Dtos.Requests.CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            await _serviceCustomer.RemoveAsync(customer);
        }

        public async Task UpdateAsync(Dtos.Requests.CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            await _serviceCustomer.UpdateAsync(customer);
        }
    }
}
