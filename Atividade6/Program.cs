int numero = 8;

Console.WriteLine($"Tabuada do número {numero}");

// Estrutura de repetição FOR
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($" {numero} x {i} {numero * i}");
}

// Estrutura de repetição WHILE
string[] sequencia1 = ["a","s","f","c","g","u","i","o","p","e"]; 
string[] sequencia2 = ["d","g","n","r","f","m","i","u","r","f"]; 
int contador = 0;

while (contador <= sequencia1.Length)
{    
    if (sequencia1[contador] == sequencia2[contador])
    {
        Console.WriteLine($"A letra que se encontra na mesma posição nas duas sequencias é a letra: {sequencia1[contador]}");
        break;
    } 

    contador++;
}

// Estrutura de repetição DO-WHILE
Random randNum = new Random();

int entrada = 0;
int escolhido = randNum.Next(0,100);

Console.WriteLine("Encontre um numero perdido entre 0 á 100");

do 
{
    entrada = Convert.ToInt32(Console.ReadLine());

    if (escolhido > entrada)
    {
        Console.WriteLine($"O numero perdido é maior que {entrada}");
    } else {
        Console.WriteLine($"O numero perdido é menor que {entrada}");
    }

} while (entrada != escolhido);

Console.WriteLine($"Acertou! o numero perdido é {escolhido}");