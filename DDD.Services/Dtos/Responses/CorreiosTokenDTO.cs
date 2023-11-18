namespace DDD.Application.Dtos.Responses
{
    public record CorreiosTokenDTO(string Ambiente, string Ip, string Perfil, string Cpf, DateTime Emissao, DateTime ExpiraEm, string ZoneOffset, string Token)
    {
        
    }
}
