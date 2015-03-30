using NetCoders.MicroErpDD.Domain.Exceptions;
using System.Runtime.InteropServices;

namespace NetCoders.MicroErpDD.Domain.Entities
{
    public sealed class Produto
    {
        /// <summary>
        /// Esse construtor ficou como "internal", para somente a Factory, que esta dentro deste projeto, utilizar para fabricar essa classe Produto sem 
        /// ter que utilizar o outro construtor, que possiu validações.
        /// </summary>
        /// <param name="idProduto"></param>
        /// <param name="nome"></param>
        internal Produto(int idProduto, [Optional]string nome)
        {
            this.IdProduto = idProduto;
            this.Nome = nome;
        }

        public Produto(int idProduto)
        {
            IdProduto = idProduto;
        }

        public Produto(string nome)
        {
            AlterarNome(nome);
        }
        public int IdProduto { get; set; }

        public string Nome { get; private set; }

        public void AlterarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ProdutoException("O nome do Produto é obrigátorio!");

            this.Nome = nome;
        }
    }
}
