namespace DDD.Application.Interfaces
{
    public interface IApplicationServiceCorreiosApi
    {
        Task<Dtos.Responses.CorreiosTokenDTO> GetCorreiosToken(string url,string username, string password);
    }
}
