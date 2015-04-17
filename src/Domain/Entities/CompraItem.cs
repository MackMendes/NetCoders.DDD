using NetCoders.MicroErpDD.Domain.Exceptions;
using System;

namespace NetCoders.MicroErpDD.Domain.Entities
{
    public sealed class CompraItem
    {
        #region Construtor

        internal CompraItem(int idCompraItem, Compra compra, Produto produto, int quantidade, decimal preco)
        {
            this.IdCompraItem = idCompraItem;
            this.Compra = compra;
            this.Produto = produto;
            this.Quantidade = quantidade;
            this.Preco = preco;
        }

        public CompraItem(Compra compra, Produto produto, int quantidade, decimal preco)
        {
            if (compra == null)
                throw new ArgumentNullException("compra");

            this.Compra = compra;

            AlterarProduto(produto, quantidade, preco);
        }

        #endregion

        #region Propriedades

        public int IdCompraItem { get; set; }

        public Compra Compra { get; private set; }

        public Produto Produto { get; private set; }

        public int Quantidade { get; private set; }

        public decimal Preco { get; private set; }

        public decimal Total { get { return Quantidade * Preco; } }

        #endregion

        #region Método

        /// <summary>
        /// Esse método tem o nome de AlterarProduto mas, serve para Validar o Produto e seta os valores das Propriedades Privadas
        /// </summary>
        /// <param name="produto"></param>
        /// <param name="quantidade"></param>
        /// <param name="preco"></param>
        public void AlterarProduto(Produto produto, int quantidade, decimal preco)
        {
            if (produto == null)
                throw new ArgumentNullException("produto");

            if (quantidade <= 0)
                throw new CompraException("A quantidade não pode ser menor que zero.", this.Compra);

            if (preco < 0)
                throw new CompraException("O preço não pode ser negativo!", this.Compra);

            this.Produto = produto;
            this.Quantidade = quantidade;
            this.Preco = preco;
        }

        #endregion
    }
}
