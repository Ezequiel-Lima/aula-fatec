using Aula.Entities;
using Aula.ValueObjects;

//Produto produto = new Produto(10.90M, "Cerveja");
//Console.WriteLine(produto.Descricao + " " + produto.Valor);
//produto.Valor = 11.85M;
//Console.WriteLine(produto.Descricao + " " + produto.Valor);

////Cliente cliente = new Cliente("Ezequiel", "(16) 99145-8499");
//// cliente.SetNome(""); Essa linha vai gerar uma Exception
//Console.WriteLine(cliente.Nome + " " + cliente.Telefone);
//cliente.SetNome("Leandro");
//Console.WriteLine(cliente.Nome + " " + cliente.Telefone);

List<Cliente> clientes = new List<Cliente>();
Endereco endereco = new Endereco("Maestro", "103", "Jardim", "15980-000", "Dobrada", "SP");

for (int i = 0; i < 10; i++)
{
    var nome = GeradorNome.Gerar();
    var telefone = "(16) 99145-8499";
    Cliente client = new Cliente(nome, telefone, endereco);
    clientes.Add(client);
}
    
foreach (var cliente in clientes)
{
    Console.WriteLine($"{cliente.Nome} {cliente.Telefone} {cliente.Endereco}");
}