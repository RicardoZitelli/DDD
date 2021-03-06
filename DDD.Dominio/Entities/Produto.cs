namespace DDD.Dominio.Entities
{
    public class Produto : Base
    {
        public string? Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public bool IsDisponivel { get; set; }
    }
}
