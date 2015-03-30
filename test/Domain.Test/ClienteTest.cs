using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NetCoders.MicroErpDD.Domain.Entities;
using NetCoders.MicroErpDD.Domain.Exceptions;
using NetCoders.MicroErpDD.Domain.Interfaces.Repository;
using NetCoders.MicroErpDD.Domain.Services;

namespace NetCoders.MicroErpDD.Domain.Test
{
    [TestClass]
    public class ClienteTest
    {
        private Cliente _cliente;
        private Mock<IClienteRepository> _mockClienteRepository;

        [TestInitialize]
        public void Inicialize()
        {
            var nome = "Mack Teste";
            var cpf = "12345678912";

            _cliente = new Cliente(nome, cpf);

            _mockClienteRepository = new Mock<IClienteRepository>();
        }

        [TestMethod, ExpectedException(typeof(ClienteException))]
        public void Quando_Cadastrar_Cliente_Gerar_Exception_Se_Nome_Estiver_Branco()
        {
            var nomeEmBranco = string.Empty;
            var cpf = "12345678912";
            new Cliente(nomeEmBranco, cpf);
        }

        [TestMethod, ExpectedException(typeof(ClienteException))]
        public void Quando_Cadastrar_Um_Cliente_Gerar_Exception_CPF_Estiver_Branco()
        {
            var nome = "Mack Teste";
            var cpf = string.Empty;
            new Cliente(nome, cpf);
        }

        [TestMethod]
        public void Quando_Criar_Um_Cliente_Verificar_Set_Do_Construtor()
        {
            var nome = "Mack Teste";
            var cpf = "12345678912";

            var cliente = new Cliente(nome, cpf);

            Assert.AreEqual(cliente.Nome, nome);
            Assert.AreEqual(cliente.Cpf, cpf);
        }

        [TestMethod, ExpectedException(typeof(ClienteException))]
        public void Quando_Alterar_Nome_Gerar_Exception_Se_CPF_Estiver_Em_Branco()
        {
            var newCpf = string.Empty;

            _cliente.AlterarCpf(newCpf);
        }

        [TestMethod, ExpectedException(typeof(ClienteException))]
        public void Quando_Adicionar_Um_Cliente_No_Banco_Nao_Permitir_Mesmo_Cpf()
        {
            var _clienteDomainService = new ClienteDomainService(_mockClienteRepository.Object);

            _mockClienteRepository
                .Setup(x => x.GetByCpf(_cliente.Cpf))
                .Returns(new Cliente("x", _cliente.Cpf));

            _clienteDomainService.Salvar(_cliente);
        }

    }

    
    // 1)
    //public sealed class ClienteException : Exception
    //{
    //    public ClienteException(string mensagem) : base(mensagem)
    //    {

    //    }
    //}

    // 2)
    //public sealed class Cliente
    //{
    //    public Cliente(string nome_, string cpf_)
    //    {
    //        this.AlterarNome(nome_);
    //        this.ValidarCpf(cpf_);


    //        this.Nome = nome_;
    //        this.Cpf = cpf_;
    //    }

    //    public int IdCliente { get; set; }

    //    public string Nome { get; private set; }

    //    public string Cpf { get; private set; }

    //    public void AlterarNome(string nome)
    //    {
    //        if (string.IsNullOrWhiteSpace(nome))
    //            throw new ClienteException("O nome não pode ser branco!");
    //    }

    //    private void ValidarCpf(string cpf)
    //    {
    //        if (string.IsNullOrWhiteSpace(cpf))
    //            throw new ClienteException("O CPF não pode ser branco!");
    //    }

    //    public void AlterarCpf(string cpf)
    //    {
    //        this.ValidarCpf(cpf);
    //        this.Cpf = cpf;
    //    }
    //}


    // 3)
    //public interface IClienteDomainService
    //{
    //    void Salvar(Cliente cliente);
    //}

    // 4)
    //public class ClienteDomainService : IClienteDomainService
    //{

    //    private readonly IClienteRepository _clienteRepository;

    //    public ClienteDomainService(IClienteRepository clienteRepository)
    //    {
    //        this._clienteRepository = clienteRepository;
    //    }

    //    public void Salvar(Cliente cliente)
    //    {
    //        if (_clienteRepository.GetByCpf(cliente.Cpf) != null)
    //            throw new ClienteException("Este Cpf já está cadastrado no banco!");

    //        _clienteRepository.Add(cliente);

    //    }
    //}

    // 5)
    //public interface IClienteRepository : IRepositoryBase<Cliente>
    //{
    //    Cliente GetByCpf(string cpf);
    //}

}
