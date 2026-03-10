// See https://aka.ms/new-console-template for more information
using ConceitosPOO;

Console.WriteLine("Hello, World!");
Cliente cliente;
Console.WriteLine("Informe o nome do cliente:");
string nome = Console.ReadLine();
Console.WriteLine("Informe o CPF do cliente:");
string cpf = Console.ReadLine();
cliente = new Cliente(nome, cpf);
cliente.Nome = "";
Console.WriteLine($"Nome do cliente: {cliente.Nome}");
Agencia agencia = new Agencia(123);
agencia.Nome = "UGBVR";
agencia.Telefone = "(24)3345-1700";
Console.WriteLine("Dados da agencia: " );
Console.WriteLine("Numero: " + agencia.Numero);
Console.WriteLine("Nome: " + agencia.Nome);
Console.WriteLine("Telefone: " + agencia.Telefone);