namespace DDD.Application.Dtos.Responses
{
    public class ProductTypeDto
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public DateTimeOffset DataCriacao { get; set; }
        public DateTimeOffset DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
