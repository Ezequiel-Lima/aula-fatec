namespace Tarefa1703.Entities
{
    public class Cliente
    {
        public Cliente(string nome, string telefone)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Telefone = telefone;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
    }
}
