using System.ComponentModel.DataAnnotations;

namespace SistemaDistribuidora.Components.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; } = "";

        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Preco { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser maior que zero.")]
        public int Quantidade { get; set; }
    }
}
