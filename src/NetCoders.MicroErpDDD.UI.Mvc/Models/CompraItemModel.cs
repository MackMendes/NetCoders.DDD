using System.ComponentModel.DataAnnotations;

namespace NetCoders.MicroErpDDD.UI.Mvc.Models
{
    public class CompraItemModel
    {
        [Required]
        public int IdProduto { get; set; }

        public string ProdutoNome { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        public decimal Preco { get; set; }
    }
}