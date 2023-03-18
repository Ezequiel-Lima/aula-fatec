using Tarefa1703.Entities;

IList<Cliente> clientes = new List<Cliente>
{
    new ("João", "(16) 99145-8499"),
    new ("Caio", "(16) 99132-8179"),
    new ("Ana", "(16) 98105-8490"),
    new ("Maria", "(15) 92143-4459")
};

foreach (var cliente in clientes)
{
    Console.WriteLine($"Nome: {cliente.Nome} Telefone: {cliente.Telefone}");
}

Random random = new Random();
IList<Produto> produtos = new List<Produto>();

for (int i = 1; i <= 560; i++)
{
    produtos.Add(new Produto(random.Next(1, 5000), "Produto nº" + i));
}

foreach (var produto in produtos)
{
    Console.WriteLine(produto.Descricao + ", Valor: " + produto.Valor.ToString("F2"));
}

IList<Veiculo> veiculos = new List<Veiculo>
{
    new Carro(4, 4, true, true, false, "Pionner", "Ford"),
    new Bike(0, 1, false, 75)
};

foreach (var veiculo in veiculos)
{
    Console.WriteLine("Assentos: " + veiculo.NumeroAssentos + " Motor: " + veiculo.TemMotor);
}