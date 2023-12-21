bool maiorIdade = true;
bool possuiAutorizacao = true;

// Estrutura de condição operador OR
if (maiorIdade || possuiAutorizacao)
{
    Console.WriteLine("Entrada liberada!");
}
else 
{
    Console.WriteLine("Entrada não liberada!");
}

bool presencaMinima = true;
int n1 = 8;
int n2 = 4;
double n3 = 7.5;
double n4 = 9.5;
double media = (n1 + n2 + n3 + n4) * 4;

// Estrutura de condição operador AND
if (presencaMinima && media >= 7)
{
    Console.WriteLine("Você passou de ano!");
}
else {
    Console.WriteLine("Você não passou de ano!");
}

bool chuva = false;
bool estaTarde = true; 

// Estrutura de condição operador NOT
if (!chuva && !estaTarde)
{
    Console.WriteLine("Vou pedalar!");
}
else {
    Console.WriteLine("Não vou pedalar!");
}