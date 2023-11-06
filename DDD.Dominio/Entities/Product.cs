using System.ComponentModel.DataAnnotations;

namespace DDD.Domain.Entities
{
    public class Product : Base
    {
        [Required]
        public string? Nome { get; set; }
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public bool IsDisponivel { get; set; }        
    }
}
