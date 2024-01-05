using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

ValidacoesPreco validacao = new ValidacoesPreco();

do
{
    Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
    validacao.CapturarPreco(Console.ReadLine());
    precoInicial = validacao.preco;
}
while (precoInicial == 0);


do
{
    Console.WriteLine("Agora digite o preço por hora:");
    validacao.CapturarPreco(Console.ReadLine());
    precoPorHora = validacao.preco;
}
while (precoPorHora == 0);

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;

        case "2":
            estacionamento.RemoverVeiculo();
            break;

        case "3":
            estacionamento.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione a tecla 'ENTER' para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
