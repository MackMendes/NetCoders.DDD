using NetCoders.MicroErpDD.Domain.Entities;
using NetCoders.MicroErpDD.Domain.Factories;
using NetCoders.MicroErpDD.Domain.Interfaces.Repository;
using NetCoders.MicroErpDDD.Infra.Repositories.Base;
using System;
using System.Collections.Generic;

namespace NetCoders.MicroErpDDD.Infra.Repositories
{
     public class CompraRepository : RepositoryBase<Compra>, ICompraRepository
    {
        public override Compra Get(int id)
        {
            //TODO: s
            throw new NotImplementedException();
        }

        public override IEnumerable<Compra> Get()
        {
            //TODO: 
            throw new NotImplementedException();
        }

        public override void Add(Compra entity)
        {
            //TODO: 
            entity.IdCompra = 1;
        }

        public override void Update(Compra entity)
        {
            //TODO:
        }

        public override void Delete(int id)
        {
            //TODO:
        }

        public IEnumerable<Compra> ConsultarComFornecedor()
        {
            Connection.CommandText = "ConsultarCompraComFornecedor";
            return Connection.GetList(CompraFactory.CreateComFornecedor);
        }
    }
}