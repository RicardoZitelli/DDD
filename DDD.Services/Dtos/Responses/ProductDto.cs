namespace DDD.Application.Dtos.Responses
{
    public class ProductDto
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public bool IsDisponivel { get; set; }
        public int TipoProdutoId { get; set; }
    }
}
