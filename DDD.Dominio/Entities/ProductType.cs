namespace DDD.Domain.Entities
{
    public class ProductType : Base
    {
        public string? Descricao { get; set; }
        public DateTimeOffset DataCriacao { get; set; }
        public DateTimeOffset? DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
