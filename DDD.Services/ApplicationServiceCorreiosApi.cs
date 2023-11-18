using AutoMapper;
using DDD.Application.Interfaces;
using DDD.Application.Dtos.Responses;
using DDD.Domain.Services.Interfaces;


namespace DDD.Application
{
    public class ApplicationServiceCorreiosApi(IServiceCorreiosApi correiosApi, IMapper mapper) : IApplicationServiceCorreiosApi
    {
        private readonly IServiceCorreiosApi _correiosApi = correiosApi;
        private readonly IMapper _mapper = mapper;

        public async Task<CorreiosTokenDTO> GetCorreiosToken(string url, string username, string password)
        {
            return _mapper.Map<CorreiosTokenDTO>(await _correiosApi.GetToken(url, username, password));
        }
    }
}
