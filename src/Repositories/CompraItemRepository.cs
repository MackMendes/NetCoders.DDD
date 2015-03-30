using NetCoders.MicroErpDD.Domain.Entities;
using NetCoders.MicroErpDD.Domain.Factories;
using NetCoders.MicroErpDD.Domain.Interfaces.Repository;
using NetCoders.MicroErpDDD.Infra.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Data;

namespace NetCoders.MicroErpDDD.Infra.Repositories
{
    public sealed class CompraItemRepository : RepositoryBase<CompraItem>, ICompraItemRepository
    {
        public override CompraItem Get(int id)
        {
            base.Connection.CommandText = "ConsultarProdutoPorIdProduto";
            base.Connection.AddWithValue("@IdProduto", id, DbType.Int32);
            //return base.Connection.GetSingle(CompraItemFactory.Create);

            throw new NotImplementedException();
        }

        public override IEnumerable<CompraItem> Get()
        {
            throw new NotImplementedException();
        }

        public override void Add(CompraItem entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(CompraItem entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CompraItem> GetByCompra(Compra compra)
        {
            base.Connection.CommandText = "ConsultarCompraItemPorIdCompra";
            base.Connection.AddWithValue("@IdCompra", compra.IdCompra, DbType.Int32);
            // Com esse Delegate abaixo, estavamos passando o x (DataReader) e o outro é o Objeto compra (Compra do Parâmetro abaixo)
            return base.Connection.GetList(x => CompraFactory.CreateItem(x, compra));
        }
    }
}
