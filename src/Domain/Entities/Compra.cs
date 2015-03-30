using NetCoders.MicroErpDD.Domain.ObjectValues;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NetCoders.MicroErpDD.Domain.Entities
{
    public sealed class Compra
    {
        internal Compra(int idCompra, Fornecedor fornecedor, DateTime dataCadastro)
        {
            IdCompra = idCompra;
            Fornecedor = fornecedor;
            DataCadastro = dataCadastro;
            Itens = new List<CompraItem>();
        }

        public Compra(Fornecedor fornecedor)
        {
            this.AlterFornecedor(fornecedor);

           this.Fornecedor = fornecedor;
           this.DataCadastro = DateTime.Now;
           this.Itens = new List<CompraItem>();
        }

        public int IdCompra { get; set; }

        /// <summary>
        /// A pergunta que têm que ser feito... quem define o Fornecedor? É a Compra... sendo assim, faz mais sentido deixa-lá como private!
        /// </summary>
        public Fornecedor Fornecedor { get; private set; }

        /// <summary>
        /// A pergunta é... Quem seta a DataCadastro? A compra... então, private!
        /// </summary>
        public DateTime DataCadastro { get; private set; }

        /// <summary>
        /// Quem define os itens da compra? A Compra! Então... private!
        /// </summary>
        public IList<CompraItem> Itens { get; private set; }

        /// <summary>
        /// Quem define Endereco????
        /// </summary>
        public Endereco Endereco { get; private set; }

        /// <summary>
        /// Altera Fornecedor, exporto para todos.
        /// </summary>
        /// <param name="fornecedor"></param>
        public void AlterFornecedor(Fornecedor fornecedor)
        {
            if (fornecedor == null)
                throw new ArgumentNullException("fornecedor");
            

            this.Fornecedor = fornecedor;
        }

        public void AdicionarItem(CompraItem compraItem)
        {
            if (!compraItem.Compra.Equals(this))
                throw new ArgumentOutOfRangeException("compraItem");

            Itens.Add(compraItem);
        }

        /// <summary>
        /// Esse método é para Adicionar o produto, quantidade e preço, do ItemCompra
        /// </summary>
        /// <param name="produto"></param>
        /// <param name="quantidade"></param>
        /// <param name="preco"></param>
        public void AdicionarItem(Produto produto, int quantidade, decimal preco)
        {
            // Esse "this" é desta Classe Compra... si propria.
            Itens.Add(new CompraItem(this, produto, quantidade, preco));
        }

        /// <summary>
        /// Remove o Item da CompraItem
        /// </summary>
        /// <param name="compraItem"></param>
        public void RemoverItem(CompraItem compraItem)
        {
            if (compraItem == null)
                throw new ArgumentNullException("compraItem");

            Itens.ToList().Remove(compraItem);
        }

        /// <summary>
        /// Alterar o objeto de valor Endereço, exporto para todos.
        /// </summary>
        /// <param name="endereco"></param>
        public void AlterarEndereco(Endereco endereco)
        {
            this.Endereco = endereco;
        }
    }
}
