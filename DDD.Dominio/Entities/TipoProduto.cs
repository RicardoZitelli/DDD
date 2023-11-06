namespace DDD.Domain.Entities
{
    public class TipoProduto : Base
    {
        public string? Descricao { get; set; }
        public DateTimeOffset DataCriacao { get; set; }
        public DateTimeOffset? DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
