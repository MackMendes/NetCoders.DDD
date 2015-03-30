using System;

namespace NetCoders.MicroErpDD.Domain.Exceptions
{
    public sealed class ClienteException : Exception
    {
        public ClienteException(string mensagem)
            : base(mensagem)
        {

        }
    }
}
