using DDD.Domain.Entities;

namespace DDD.Domain.Services.Interfaces
{
    public interface IServiceCorreiosApi
    {
        Task<CorreiosToken> GetToken(string url, string username, string password);
    }
}
