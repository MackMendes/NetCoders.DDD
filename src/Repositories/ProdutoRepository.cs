using NetCoders.MicroErpDD.Domain.Entities;
using NetCoders.MicroErpDD.Domain.Factories;
using NetCoders.MicroErpDD.Domain.Interfaces.Repository;
using NetCoders.MicroErpDDD.Infra.Repositories.Base;
using System.Collections.Generic;
using System.Data;

namespace NetCoders.MicroErpDDD.Infra.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public override Produto Get(int id)
        {
            base.Connection.CommandText = "ConsultarProdutoPorIdProduto";
            base.Connection.AddWithValue("@IdProduto", id, DbType.Int32);
            return base.Connection.GetSingle(ProdutoFactory.Create);
        }

        public override IEnumerable<Produto> Get()
        {
            base.Connection.CommandText = "ConsultarProdutos";
            return base.Connection.GetList(ProdutoFactory.Create);
        }

        public override void Add(Produto entity)
        {
            base.Connection.CommandText = "AdicionarProduto";
            this.AddParams(entity);
            entity.IdProduto = base.Connection.ExecuteScalar<int>();
        }

        public override void Update(Produto entity)
        {
            //TODO: Esse To Do é uma Paranaue que fica na Task List... LOKO!!!
            base.Connection.CommandText = "AtualizarProdutoPorIdProduto";
            this.AddParamId(entity.IdProduto);
            this.AddParams(entity);
            base.Connection.ExecuteNonQuery();
        }

        public override void Delete(int id)
        {
            // TODO: Criar procedure depois
            base.Connection.CommandText = "DELETE Produto WHERE IdProduto = @IdProduto;";
            base.Connection.CommandType = CommandType.Text;
            this.AddParamId(id);
            base.Connection.ExecuteNonQuery();
        }

        private void AddParams(Produto entity)
        {
            base.Connection.AddWithValue("@Nome", entity.Nome, DbType.String);
        }

        private void AddParamId(int id)
        {
            base.Connection.AddWithValue("@IdProduto", id, DbType.Int32);
        }
    }
}
