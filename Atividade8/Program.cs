int media = 0;
int[] arrayInteiros = new int[3]; // Declarando o array em C#

Console.WriteLine("Digite um numero");
arrayInteiros[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro numero");
arrayInteiros[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite mais outro numero");
arrayInteiros[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("==========================");
Console.WriteLine("Numeros digitados (For):");

// Varrendo array com for
for (int i = 0; i < arrayInteiros.Length; i++)
{
    media += arrayInteiros[i];
    Console.WriteLine($"Posição N°{i} - {arrayInteiros[i]}");
}

Console.WriteLine($"Media final: {media/3}");
Console.WriteLine("==========================");

Console.WriteLine("Numeros digitados (Foreach):");
media = 0;

// Varrendo array com foreach
foreach (var item in arrayInteiros)
{
    media += item;
    Console.WriteLine($"Elemnto no array: - {item}");
}

Console.WriteLine($"Media final: {media/3}");