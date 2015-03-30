using NetCoders.MicroErpDD.Domain.Entities;
using System;

namespace NetCoders.MicroErpDD.Domain.Exceptions
{
    public sealed class CompraException : Exception
    {
        public Compra Compra { get; private set; }

        public CompraException(string mensagem) : base(mensagem) { }

        public CompraException(string mensagem, Exception innerException) : base(mensagem, innerException) { }

        public CompraException(string mensagem, Compra compra)
            : base(mensagem) { this.Compra = compra; }
    }
}
