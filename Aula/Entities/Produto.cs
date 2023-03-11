namespace Aula.Entities
{
    public class Produto
    {
        public Produto(decimal valor, string descricao)
        {
            Id = Guid.NewGuid();
            Valor = valor;
            Descricao = descricao;
        }

        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
    }
}
