using NetCoders.MicroErpDD.Domain.Entities;
using System;

namespace NetCoders.MicroErpDD.Domain.Exceptions
{
    public class FornecedorException : Exception
    {
        public Fornecedor Fornecedor { get; private set; }

        public FornecedorException(string mensagem) : base(mensagem) { }

        public FornecedorException(string mensagem, Exception innerException) : base(mensagem, innerException) { }

        public FornecedorException(string mensagem, Fornecedor fornecedor)
            : base(mensagem) { this.Fornecedor = fornecedor; }
    }
}
