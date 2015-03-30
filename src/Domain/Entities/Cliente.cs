using NetCoders.MicroErpDD.Domain.Exceptions;

namespace NetCoders.MicroErpDD.Domain.Entities
{
    public sealed class Cliente
    {
        public Cliente(string nome_, string cpf_)
        {
            this.AlterarNome(nome_);
            this.ValidarCpf(cpf_);


            this.Nome = nome_;
            this.Cpf = cpf_;
        }

        public int IdCliente { get; set; }

        public string Nome { get; private set; }

        public string Cpf { get; private set; }

        public void AlterarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ClienteException("O nome não pode ser branco!");
        }

        private void ValidarCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                throw new ClienteException("O CPF não pode ser branco!");
        }

        public void AlterarCpf(string cpf)
        {
            this.ValidarCpf(cpf);
            this.Cpf = cpf;
        }
    }
}
