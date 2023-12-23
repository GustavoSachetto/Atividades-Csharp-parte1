string opcao;

while (true)
{

    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o id do cliente para cadastrar:");
            break;
        case "2":
            Console.WriteLine("Digite o id do cliente para buscar:");
            break;
        case "3":
            Console.WriteLine("Digite o id do cliente para apagar:");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
