namespace Tarefa1703.Entities
{
    public class Produto
    {
        public Produto(decimal valor, string descricao)
        {
            Id = Guid.NewGuid();
            Valor = valor;
            Descricao = descricao;
        }

        public Guid Id { get; private set; }
        public decimal Valor { get; private set; }
        public string Descricao { get; private set; }
    }
}
