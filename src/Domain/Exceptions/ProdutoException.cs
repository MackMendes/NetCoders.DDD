using NetCoders.MicroErpDD.Domain.Entities;
using System;

namespace NetCoders.MicroErpDD.Domain.Exceptions
{
    public class ProdutoException : Exception
    {
        public Produto Produto { get; private set; }

        public ProdutoException(string mensagem) : base(mensagem) { }

        public ProdutoException(string mensagem, Exception innerException) : base(mensagem, innerException) { }

        public ProdutoException(string mensagem, Produto produto)
            : base(mensagem) { this.Produto = produto; }
    }
}
