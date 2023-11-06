namespace DDD.Domain.Entities
{
    public class Cliente : Base
    {

        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string? Email { get; set; }
        public DateTimeOffset DataCadastro { get; set; }
        public bool IsAtivo { get; set; }

    }
}
