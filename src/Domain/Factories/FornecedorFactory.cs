using NetCoders.MicroErpDD.Domain.Entities;
using System.Data;

namespace NetCoders.MicroErpDD.Domain.Factories
{
    public static class FornecedorFactory
    {
        public static Fornecedor Create(IDataReader dataReader)
        {
            return new Fornecedor(
                (int)dataReader["IdFornecedor"],
                (string)dataReader["Nome"]);
        }
    }
}
