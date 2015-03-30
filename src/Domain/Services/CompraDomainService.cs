using NetCoders.MicroErpDD.Domain.Interfaces.Services;
using System;
using System.Linq;

namespace NetCoders.MicroErpDD.Domain.Services
{
    public class CompraDomainService : ICompraDomainService
    {
        public void ValidarItensCompra(Entities.Compra compra)
        {
            if (compra.Itens.Count() <= 0)
                throw new ArgumentNullException("Por favor, informar os itens da compra.");
        }
    }
}
