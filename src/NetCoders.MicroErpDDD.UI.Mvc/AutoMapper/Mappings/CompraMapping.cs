using AutoMapper;
using NetCoders.MicroErpDD.Domain.Entities;
using NetCoders.MicroErpDD.Domain.Factories;
using NetCoders.MicroErpDD.Domain.ObjectValues;
using NetCoders.MicroErpDDD.UI.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetCoders.MicroErpDDD.UI.Mvc.AutoMapper.Mappings
{
    public static class CompraMapping
    {
        public static CompraModel OutCompraModel(Compra compra)
        {
            var compraModel = new CompraModel
            {
                IdFornecedor = compra.Fornecedor.IdFornecedor,
                FornecedorNome = compra.Fornecedor.Nome,
                DataCadastro = compra.DataCadastro
            };

            foreach (var compraItem in compra.Itens)
                compraModel.Itens.Add(new CompraItemModel
                {
                    IdProduto = compraItem.Produto.IdProduto,
                    Preco = compraItem.Preco,
                    Quantidade = compraItem.Quantidade
                });

            return compraModel;
        }

        public static Compra OutCompra(CompraModel compraModel)
        {
            var compra = new Compra(new Fornecedor(compraModel.IdFornecedor));
            foreach (var compraItemModel in compraModel.Itens)
                compra.AdicionarItem(
                    CompraFactory.CreateItem(
                    compra,
                    new Produto(compraItemModel.IdProduto),
                    compraItemModel.Quantidade,
                    compraItemModel.Preco));

            return compra;
        }
    }
}