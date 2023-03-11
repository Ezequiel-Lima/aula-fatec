using Aula.ValueObjects;

namespace Aula.Entities
{
    public class Cliente
    {
        public Cliente(string nome, string telefone, Endereco endereco)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public Endereco Endereco { get; private set; }

        public void SetNome(string nome)
        {
            Validar(nome);
            Nome = nome;
        }

        public void Validar(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentNullException("Campo Vazio");
            }
        }
    }
}
