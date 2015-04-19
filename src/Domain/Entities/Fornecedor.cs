using NetCoders.MicroErpDD.Domain.Exceptions;

namespace NetCoders.MicroErpDD.Domain.Entities
{
    public sealed class Fornecedor
    {
        #region Construtur

        internal Fornecedor(int idFornecedor, string nome)
        {
            IdFornecedor = idFornecedor;
            Nome = nome;
        }

        public Fornecedor(int idFornecedor)
        {
            this.IdFornecedor = idFornecedor;
        }

        public Fornecedor(string nome)
        {
            this.AlterarNome(nome);
        }

        #endregion

        #region Propriedades

        public int IdFornecedor { get; set; }

        public string Nome { get; private set; }

        #endregion

        #region Métodos

        public void AlterarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new FornecedorException("O nome é obrigatório!");

            this.Nome = nome;
        }

        #endregion
    }
}
