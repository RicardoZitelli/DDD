namespace DDD.Application.Dtos
{
    public class ProdutoDto
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public bool IsDisponivel { get; set; }
    }
}
