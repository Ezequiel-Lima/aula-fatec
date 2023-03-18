using System.Text;

namespace Tarefa1703.Entities
{
    public class Venda
    {
        public Venda(Cliente cliente, IList<Produto> produtos)
        {
            Id = Guid.NewGuid();
            Data = DateTime.UtcNow;
            Cliente = cliente;
            Produtos = produtos;
        }

        public Guid Id { get; private set; }
        public DateTime Data { get; private set; }
        public Cliente Cliente { get; private set; }
        public IList<Produto> Produtos { get; private set; }
    }
}
