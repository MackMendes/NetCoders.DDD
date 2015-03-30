using NetCoders.MicroErpDD.Domain.Exceptions;

namespace NetCoders.MicroErpDD.Domain.Entities
{
    public sealed class Fornecedor
    {
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

        public int IdFornecedor { get; set; }

        public string Nome { get; private set; }

        public void AlterarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new FornecedorException("O nome é obrigatório!");

            this.Nome = nome;
        }
    }
}
