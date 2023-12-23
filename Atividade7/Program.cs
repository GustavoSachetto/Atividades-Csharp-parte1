using Atividade7.Models;

int cont = 0;
string[] clientes = [];

while (true)
{

    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Exibir cliente");
    Console.WriteLine("3 - Buscar cliente");
    Console.WriteLine("4 - Apagar cliente");
    Console.WriteLine("5 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Cliente cliente[cont] = new Cliente();
            cliente[cont].Id = cont;

            Console.WriteLine("Digite o nome do novo cliente:");
            cliente[cont].Nome = Console.ReadLine();

            Console.WriteLine("Digite o ano de nascimento do novo cliente:");
            cliente[cont].Nasc = Console.ReadLine();
            clientes[cont] = cliente[cont];

            cont++;
            break;
        case "2":
            Console.WriteLine("Clientes cadastrados:");
            for (int i = 0; i <= clientes.Length; i++)
            {
                Console.WriteLine($"==================Cliente{[i]}===================");
                Console.WriteLine($"Identificador: {cliente[i].Id}");
                Console.WriteLine($"Nome: {cliente[i].Nome}");
                Console.WriteLine($"Idade: {cliente[i].ConsultaIdade()}");
            }
            break;
        case "3":
            Console.WriteLine("Digite o id do cliente para buscar:");
            break;
        case "4":
            Console.WriteLine("Digite o id do cliente para apagar:");
            break;
        case "5":
            Console.WriteLine("Encerrar");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
