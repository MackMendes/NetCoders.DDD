using NetCoders.MicroErpDD.Domain.Entities;
using System.Data;

namespace NetCoders.MicroErpDD.Domain.Factories
{
    public static class ProdutoFactory
    {
        public static Produto Create(IDataReader dataReader)
        {
            return new Produto(
                (int)dataReader["IdProduto"],
                (string)dataReader["Nome"]);
        }
    }
}
