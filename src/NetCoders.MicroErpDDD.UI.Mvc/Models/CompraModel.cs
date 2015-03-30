using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoders.MicroErpDDD.UI.Mvc.Models
{
    public class CompraModel
    {
        [Required]
        public int IdFornecedor { get; set; }
        public string FornecedorNome { get; set; }
        public DateTime DataCadastro { get; set; }
        public IList<CompraItemModel> Itens { get; set; }
    }
}