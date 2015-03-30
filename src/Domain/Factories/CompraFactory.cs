using NetCoders.MicroErpDD.Domain.Entities;
using System;
using System.Data;

namespace NetCoders.MicroErpDD.Domain.Factories
{
    public static class CompraFactory
    {
        public static Compra CreateComFornecedor(IDataReader dataReader)
        {
            var fornecedor = new Fornecedor((string)dataReader["NomeFornecedor"])
            {
                IdFornecedor = (int)dataReader["IdFornecedor"]
            };
            return new Compra((int)dataReader["IdCompra"], fornecedor, (DateTime)dataReader["DataCadastro"]);
        }

        public static CompraItem CreateItem(IDataReader dataReader, Compra compra)
        {
            var compraItem = new CompraItem(
                (int)dataReader["IdCompraItem"],
                compra,
                new Produto((int)dataReader["IdProduto"]),
                (int)dataReader["Quantidade"],
                (decimal)dataReader["Preco"]);

            compra.AdicionarItem(compraItem);

            return compraItem;
        }

        public static CompraItem CreateItem(Compra compra, Produto produto, int quantidade, decimal preco)
        {
            return new CompraItem(compra, produto, quantidade, preco);
        }
    }
}
