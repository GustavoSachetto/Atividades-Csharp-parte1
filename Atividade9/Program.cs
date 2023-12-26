using Atividade9.Models;

string opcao;
int contador = 0;
string[] clientes = new string[1];
string[] copyClientes = new string[1];
Cliente novoCliente = new Cliente();

Console.WriteLine("===================Bem-vindo===================");
Console.WriteLine("Esse programa é um simples exemplo de estrutura de cadastro!");

bool verificaClientes(int idCliente) {
    if (!(idCliente > (clientes.Length - 1)))
    {
        return true;
    }
    return false;
}

while (true)
{
    Console.WriteLine("===============================================");
    Console.WriteLine("Digite abaixo o que você deseja fazer:");
    Console.WriteLine("===============================================");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Exibir clientes");
    Console.WriteLine("5 - Encerrar");
    Console.WriteLine("===============================================");

    opcao = Console.ReadLine();
    Console.Clear();

    switch (opcao)
    {
        case "1":
            Array.Resize(ref clientes, contador + 1);
            Array.Resize(ref copyClientes, contador + 1);

            Console.WriteLine("===================Cadastrar===================");

            Console.WriteLine("Digite o nome do (novo) cliente:");
            novoCliente.Nome = Console.ReadLine();
            
            Console.WriteLine("Digite o ano de nascimento do (novo) cliente:");
            novoCliente.Nasc = Convert.ToInt32(Console.ReadLine());

            clientes[contador] = $"Nome: {novoCliente.Nome}\nIdade: {novoCliente.VerficaIdade()}";
            contador++;
            
            Console.WriteLine("===================Sucesso=====================");
            break;
        case "2":
            Console.WriteLine("====================Buscar=====================");
            Console.WriteLine("Digite o id do cliente para buscar:");
            int busca = Convert.ToInt32(Console.ReadLine());

            ;

            if (verificaClientes(busca))
            {
                Console.WriteLine($"===============Cliente [@id: {busca}]================");
                Console.WriteLine(clientes[busca]);
                Console.WriteLine("===================Sucesso=====================");
            } else
            {
                Console.WriteLine($"===============Cliente [@id: {busca}]================");
                Console.WriteLine($"Cliente não encontrado!");
                Console.WriteLine("====================Error======================");
            }
            break;
        case "3":
            Console.WriteLine("====================Apagar=====================");
            Console.WriteLine("Digite o id do cliente para apagar:");
            int apagar = Convert.ToInt32(Console.ReadLine());

            if (verificaClientes(apagar))
            {
                Console.WriteLine("Você realmente deseja apagar?");
                Console.WriteLine("0 = NÃO | 1 = SIM");
                int decisao = Convert.ToInt32(Console.ReadLine());
                if (Convert.ToBoolean(decisao))
                {
                    Console.WriteLine($"===============Cliente [@id: {apagar}]================");
                    Console.WriteLine(clientes[apagar] = "Cliente apagado");
                    Console.WriteLine("====================Sucesso======================");
                }
            } else
            {
                Console.WriteLine($"===============Cliente [@id: {apagar}]================");
                Console.WriteLine($"Cliente não encontrado!");
                Console.WriteLine("====================Error======================");
            }
            break;
        case "4":
            Console.WriteLine("===================Exibir====================");
            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine($"===============Cliente [@id: {i}]================");
                Console.WriteLine(clientes[i]);
            }
            Console.WriteLine("====================Sucesso======================");
            break;
        case "5":
            Console.WriteLine("===================Encerrar====================");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Array.Copy(clientes, copyClientes, clientes.Length);
}
