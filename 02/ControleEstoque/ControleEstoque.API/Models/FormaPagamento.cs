using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.API.Models
{
    public class FormaPagamento
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [StringLength(255)]
        public string? Descricao { get; set; }

        public bool Ativo { get; set; }
    }
}
