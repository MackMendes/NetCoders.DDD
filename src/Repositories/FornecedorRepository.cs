using NetCoders.MicroErpDD.Domain.Entities;
using NetCoders.MicroErpDD.Domain.Factories;
using NetCoders.MicroErpDD.Domain.Interfaces.Repository;
using NetCoders.MicroErpDDD.Infra.Repositories.Base;
using System;
using System.Collections.Generic;

namespace NetCoders.MicroErpDDD.Infra.Repositories
{
    public class FornecedorRepository : RepositoryBase<Fornecedor>, IFornecedorRepository
    {
        public override Fornecedor Get(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Fornecedor> Get()
        {
            Connection.CommandText = "ConsultarFornecedores";
            return Connection.GetList(FornecedorFactory.Create);
        }

        public override void Add(Fornecedor entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Fornecedor entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
