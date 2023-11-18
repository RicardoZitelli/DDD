using System.Text.Json.Serialization;

namespace DDD.Domain.Entities
{
    public sealed class CorreiosToken(string ambiente, string ip, string perfil, string cpf, DateTime emissao, DateTime expiraEm, string zoneOffset, string token) : Base
    {
        [JsonPropertyName("ambiente")]
        public string Ambiente { get; set; } = ambiente;
        [JsonPropertyName("ip")]
        public required string Ip { get; set; } = ip;
        [JsonPropertyName("perfil")]
        public required string Perfil { get; set; } = perfil;
        [JsonPropertyName("cpf")]
        public required string Cpf { get; set; } = cpf;
        [JsonPropertyName("emissao")]
        public DateTime Emissao { get; set; } = emissao;
        [JsonPropertyName("expiraEm")]
        public DateTime ExpiraEm { get; set; } = expiraEm;
        [JsonPropertyName("zoneOffset")]
        public required string ZoneOffset { get; set; } = zoneOffset;
        [JsonPropertyName("token")]
        public required string Token { get; set; } = token;
    }
}