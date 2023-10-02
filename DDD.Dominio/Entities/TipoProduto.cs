namespace DDD.Domain.Entities
{
    public class TipoProduto : Base
    {
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
