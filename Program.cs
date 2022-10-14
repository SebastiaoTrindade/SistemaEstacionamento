
using SistemaEstacionamento.Models;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao Sistema de Estacionamento!\n");
Console.WriteLine("Digite o valor inicial:");

precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor por hora:");

precoPorHora = Convert.ToDecimal(Console.ReadLine());


Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = String.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:\n");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Encerrar\n");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção Inválida");
            break;
    }

    Console.WriteLine("Pressione qualquer tecla para sair");
    Console.ReadLine();
}

Console.WriteLine("O programa foi encerrado..");