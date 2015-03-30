using NetCoders.MicroErpDD.Domain.Entities;
using NetCoders.MicroErpDD.Domain.Exceptions;
using NetCoders.MicroErpDD.Domain.Interfaces.Repository;
using NetCoders.MicroErpDD.Domain.Interfaces.Services;

namespace NetCoders.MicroErpDD.Domain.Services
{
    public class ClienteDomainService : IClienteDomainService
    {

        private readonly IClienteRepository _clienteRepository;

        public ClienteDomainService(IClienteRepository clienteRepository)
        {
            this._clienteRepository = clienteRepository;
        }

        public void Salvar(Cliente cliente)
        {
            if (_clienteRepository.GetByCpf(cliente.Cpf) != null)
                throw new ClienteException("Este Cpf já está cadastrado no banco!");

            _clienteRepository.Add(cliente);

        }
    }
}
